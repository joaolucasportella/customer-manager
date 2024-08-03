UPDATE customers
SET
    name = @name,
    rg = @rg,
    cpf = @cpf,
    address = @address,
    cep = @cep,
    city = @city,
    email = @email,
    phone1 = @phone1,
    phone2 = @phone2,
    birthDate = @birthDate,
    updatedAt = datetime('now', 'localtime')
WHERE id = @id;
