BEGIN TRANSACTION;

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

UPDATE anamnesis
SET
    previousEstheticTreatment = @previousEstheticTreatment,
    specifyPreviousEstheticTreatment = @specifyPreviousEstheticTreatment,
    allergies = @allergies,
    specifyAllergies = @specifyAllergies,
    regularIntestinalFunction = @regularIntestinalFunction,
    specifyRegularIntestinalFunction = @specifyRegularIntestinalFunction,
    practiceSports = @practiceSports,
    specifyPracticeSports = @specifyPracticeSports,
    balancedDiet = @balancedDiet,
    specifyBalancedDiet = @specifyBalancedDiet,
    medicalTreatment = @medicalTreatment,
    specifyMedicalTreatment = @specifyMedicalTreatment,
    useMedications = @useMedications,
    specifyUseMedications = @specifyUseMedications,
    pacemaker = @pacemaker,
    specifyPacemaker = @specifyPacemaker,
    metalProstheses = @metalProstheses,
    specifyMetalProstheses = @specifyMetalProstheses,
    heartProblems = @heartProblems,
    specifyHeartProblems = @specifyHeartProblems,
    oncologicalHistory = @oncologicalHistory,
    specifyOncologicalHistory = @specifyOncologicalHistory,
    menstrualCycle = @menstrualCycle,
    specifyMenstrualCycle = @specifyMenstrualCycle,
    contraceptiveMethod = @contraceptiveMethod,
    specifyContraceptiveMethod = @specifyContraceptiveMethod,
    dailyCareProducts = @dailyCareProducts,
    specifyDailyCareProducts = @specifyDailyCareProducts,
    pregnant = @pregnant,
    hasChildren = @hasChildren,
    childrenQuantity = @childrenQuantity,
    smoke = @smoke,
    epilepsy = @epilepsy,
    diabetes = @diabetes,
    dentalProsthesis = @dentalProsthesis,
    sunExposure = @sunExposure,
    hypertensive = @hypertensive
WHERE customerId = @id;

COMMIT;
