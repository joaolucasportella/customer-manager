INSERT INTO customers (
    name,
    rg,
    cpf,
    address,
    cep,
    city,
    email,
    phone1,
    phone2,
    birthDate
) VALUES (
    @name,
    @rg,
    @cpf,
    @address,
    @cep,
    @city,
    @email,
    @phone1,
    @phone2,
    @birthDate
);
