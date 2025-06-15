# 📚 Book Management API

A simple RESTful API for managing a collection of books and their authors.

## 🧾 Features

- Retrieve all books
- Retrieve a specific book by ID
- Create a new book with an associated author
- Update an existing book's details
- Delete a book

---

## 🏗️ Data Models

### 📘 Book

| Property  | Type    | Description                            |
|-----------|---------|----------------------------------------|
| BookId    | Integer | Unique identifier for the book         |
| Title     | String  | Title of the book                      |
| Genre     | String  | Genre of the book                      |
| Author    | Object  | Author details (see below)             |

### 👨‍💼 Author

| Property  | Type    | Description                            |
|-----------|---------|----------------------------------------|
| AuthorId  | Integer | Unique identifier for the author       |
| Name      | String  | Name of the author                     |

---

## 🔌 API Endpoints

### 📥 GET /api/books

**Description:** Retrieves a list of all books  
**Response:**  
```json
[
  {
    "bookId": 1,
    "title": "The Great Gatsby",
    "genre": "Classic",
    "author": {
      "authorId": 1,
      "name": "F. Scott Fitzgerald"
    }
  },
  ...
]
