CREATE TABLE customers (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT,
    rg TEXT,
    cpf TEXT,
    address TEXT,
    cep TEXT,
    city TEXT,
    email TEXT,
    phone1 TEXT,
    phone2 TEXT,
    birthDate TEXT,
    createdAt TEXT DEFAULT (datetime('now', 'localtime')),
    updatedAt TEXT DEFAULT (datetime('now', 'localtime'))
);
