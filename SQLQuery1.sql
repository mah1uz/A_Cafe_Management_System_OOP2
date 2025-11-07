-- Users
CREATE TABLE Users (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100) NOT NULL,
    Username VARCHAR(100) NOT NULL,
    Role VARCHAR(50) NOT NULL,        -- Example: 'Admin', 'Customer', 'Employee'
    Salary DECIMAL(10, 2),
    Gender VARCHAR(10),
    Status VARCHAR(20),
    Password VARCHAR(100) NOT NULL,
    Position VARCHAR(100)
);

-- Menu
CREATE TABLE Menu (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Title VARCHAR(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Status VARCHAR(20) NOT NULL
);

-- Orders
CREATE TABLE Orders (
    ID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT FOREIGN KEY REFERENCES Users(ID),
    Date DATE DEFAULT GETDATE(),
    Comment TEXT
);

-- Order Items
CREATE TABLE OrderItems (
    ID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT FOREIGN KEY REFERENCES Orders(ID),
    MenuID INT FOREIGN KEY REFERENCES Menu(ID),
    Quantity INT NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    TotalPrice AS (Quantity * Price) PERSISTED
);

-- Payment
CREATE TABLE Payment (
    ID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT FOREIGN KEY REFERENCES Orders(ID),
    Type VARCHAR(50), -- Bkash/Nagad
    Trxns VARCHAR(100),
    Phone VARCHAR(15)
);

-- Products (General Store Style)
CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    Category VARCHAR(100) NOT NULL,
    ProductName VARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    Quantity INT NOT NULL DEFAULT 0,
    Amount AS (Price * Quantity) PERSISTED
);

-- Store Orders (Non-food store)
CREATE TABLE StoreOrders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    QuantityOrdered INT NOT NULL,
    OrderDate DATE DEFAULT GETDATE(),
    PaymentType VARCHAR(50)
);


ALTER TABLE Orders
ADD Status VARCHAR(50) DEFAULT 'Pending';








INSERT INTO Users (Name, Username, Role, Salary, Gender, Status, Password, Position) VALUES

('J', '2', 'Customer', 0, 'Male', 'Active', '2', NULL),
('Jane Smith', '3', 'Employee', 15000, 'Female', 'Active', '', 'Waiter');

INSERT INTO Menu (Title, Price, Status)
VALUES
('Burger', 150.00, 'Available'),
('Pizza', 250.00, 'Available'),
('Pasta', 180.00, 'Available'),
('Coffee', 80.00, 'Available');

INSERT INTO Orders (UserID, Comment)
VALUES
(1, 'First order'),
(2, 'Urgent delivery'),
(3, 'Lunch order');
INSERT INTO OrderItems (OrderID, MenuID, Quantity, Price)
VALUES
(1, 1, 2, 150.00), -- 2x Burger
(1, 4, 1, 80.00),  -- 1x Coffee
(2, 2, 1, 250.00), -- 1x Pizza
(3, 3, 2, 180.00); -- 2x Pasta
INSERT INTO Products (Category, ProductName, Price, Quantity)
VALUES
('Electronics', 'Mouse', 500.00, 10),
('Electronics', 'Keyboard', 1000.00, 5),
('Grocery', 'Rice 5kg', 550.00, 20),
('Stationery', 'Notebook', 45.00, 100);

INSERT INTO StoreOrders (ProductID, QuantityOrdered, PaymentType)
VALUES
(1, 2, 'Cash'),       -- 2 Mice
(3, 5, 'Bkash'),      -- 5 Rice bags
(4, 10, 'Nagad');     -- 10 Notebooks
