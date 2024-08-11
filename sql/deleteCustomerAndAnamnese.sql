BEGIN TRANSACTION;

DELETE FROM anamnesis WHERE customerId = @id;

DELETE FROM customers WHERE id = @id;

COMMIT;
