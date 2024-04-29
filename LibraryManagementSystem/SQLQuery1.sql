-- Create Authors Table
CREATE TABLE Authors (
    author_id INT PRIMARY KEY IDENTITY(1,1),
    author_name NVARCHAR(100),
    nationality NVARCHAR(50),
    birth_year INT
);

-- Create Genres Table
CREATE TABLE Genres (
    genre_id INT PRIMARY KEY IDENTITY(1,1),
    genre_name NVARCHAR(50)
);

-- Create Users Table
CREATE TABLE Users (
    user_id INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(MAX) NULL,
    password NVARCHAR(MAX) NULL,
    date_register DATE NULL,
    user_authentication NVARCHAR(MAX) NULL -- Store text-based authentication tokens
);

-- Create Borrowers Table
CREATE TABLE Borrowers (
    borrower_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT, -- Foreign key referencing the id column in the Users table
    borrower_name NVARCHAR(100),
    email NVARCHAR(100),
    phone NVARCHAR(20),
    FOREIGN KEY (user_id) REFERENCES Users(user_id)
);

-- Create Books Table
CREATE TABLE Books (
    book_id INT PRIMARY KEY IDENTITY(1,1),
    title NVARCHAR(255),
    author_id INT,
    genre_id INT,
    published_year INT,
    ISBN NVARCHAR(20),
    available_quantity INT,
    FOREIGN KEY (author_id) REFERENCES Authors(author_id),
    FOREIGN KEY (genre_id) REFERENCES Genres(genre_id)
);

-- Create Transactions Table
CREATE TABLE Transactions (
    transaction_id INT PRIMARY KEY IDENTITY(1,1),
    book_id INT,
    borrower_id INT,
    transaction_date DATE,
    due_date DATE,
    return_date DATE,
    late_fee DECIMAL(10, 2),
    FOREIGN KEY (book_id) REFERENCES Books(book_id),
    FOREIGN KEY (borrower_id) REFERENCES Borrowers(borrower_id)
);

ALTER TABLE Users
ADD status VARCHAR(MAX) NULL;

-- Insert data into Authors table
INSERT INTO Authors (author_name, nationality, birth_year) VALUES
('J.K. Rowling', 'British', 1965),
('Stephen King', 'American', 1947),
('Haruki Murakami', 'Japanese', 1949),
('Jane Austen', 'British', 1775),
('George Orwell', 'British', 1903);

-- Insert data into Genres table
INSERT INTO Genres (genre_name) VALUES
('Fantasy'),
('Horror'),
('Mystery'),
('Romance'),
('Science Fiction');

-- Insert data into Users table
INSERT INTO Users (username, password, date_register, user_authentication, status) VALUES
('user1', 'password1', '2023-01-01', 'dog', 'Active'),
('user2', 'password2', '2023-01-02', 'cat', 'Active'),
('user3', 'password3', '2023-01-03', 'bird', 'Active'),
('user4', 'password4', '2023-01-04', 'fish', 'Active'),
('user5', 'password5', '2023-01-05', 'rabbit', 'Active');

-- Insert data into Borrowers table
INSERT INTO Borrowers (user_id, borrower_name, email, phone) VALUES
(1, 'John Doe', 'john@example.com', '123-456-7890'),
(2, 'Jane Smith', 'jane@example.com', '987-654-3210'),
(3, 'Michael Johnson', 'michael@example.com', '111-222-3333'),
(4, 'Emily Davis', 'emily@example.com', '444-555-6666'),
(5, 'William Wilson', 'william@example.com', '777-888-9999');

-- Insert data into Books table
INSERT INTO Books (title, author_id, genre_id, published_year, ISBN, available_quantity) VALUES
('Harry Potter and the Sorcerer''s Stone', 1, 1, 1997, '9780590353427', 10),
('The Shining', 2, 2, 1977, '9780307743657', 8),
('Norwegian Wood', 3, 3, 1987, '9780099554561', 5),
('Pride and Prejudice', 4, 4, 1813, '9781612930849', 12),
('1984', 5, 5, 1949, '9780451524935', 15);

-- Insert data into Transactions table
INSERT INTO Transactions (book_id, borrower_id, transaction_date, due_date, return_date, late_fee) VALUES
(1, 1, '2023-01-01', '2023-01-15', NULL, NULL),
(2, 2, '2023-01-02', '2023-01-16', NULL, NULL),
(3, 3, '2023-01-03', '2023-01-17', NULL, NULL),
(4, 4, '2023-01-04', '2023-01-18', NULL, NULL),
(5, 5, '2023-01-05', '2023-01-19', NULL, NULL);

SELECT * FROM Transactions;