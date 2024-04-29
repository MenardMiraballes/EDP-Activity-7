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

SELECT * FROM Transactions;