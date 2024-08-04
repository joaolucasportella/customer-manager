BEGIN TRANSACTION;

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

INSERT INTO anamnesis (
    customerId,
    previousEstheticTreatment,
    specifyPreviousEstheticTreatment,
    allergies,
    specifyAllergies,
    regularIntestinalFunction,
    specifyRegularIntestinalFunction,
    practiceSports,
    specifyPracticeSports,
    balancedDiet,
    specifyBalancedDiet,
    medicalTreatment,
    specifyMedicalTreatment,
    useMedications,
    specifyUseMedications,
    pacemaker,
    specifyPacemaker,
    metalProstheses,
    specifyMetalProstheses,
    heartProblems,
    specifyHeartProblems,
    oncologicalHistory,
    specifyOncologicalHistory,
    menstrualCycle,
    specifyMenstrualCycle,
    contraceptiveMethod,
    specifyContraceptiveMethod,
    dailyCareProducts,
    specifyDailyCareProducts,
    pregnant,
    hasChildren,
    childrenQuantity,
    smoke,
    epilepsy,
    diabetes,
    dentalProsthesis,
    sunExposure,
    hypertensive
) VALUES (
    (SELECT last_insert_rowid()),
    @previousEstheticTreatment,
    @specifyPreviousEstheticTreatment,
    @allergies,
    @specifyAllergies,
    @regularIntestinalFunction,
    @specifyRegularIntestinalFunction,
    @practiceSports,
    @specifyPracticeSports,
    @balancedDiet,
    @specifyBalancedDiet,
    @medicalTreatment,
    @specifyMedicalTreatment,
    @useMedications,
    @specifyUseMedications,
    @pacemaker,
    @specifyPacemaker,
    @metalProstheses,
    @specifyMetalProstheses,
    @heartProblems,
    @specifyHeartProblems,
    @oncologicalHistory,
    @specifyOncologicalHistory,
    @menstrualCycle,
    @specifyMenstrualCycle,
    @contraceptiveMethod,
    @specifyContraceptiveMethod,
    @dailyCareProducts,
    @specifyDailyCareProducts,
    @pregnant,
    @hasChildren,
    @childrenQuantity,
    @smoke,
    @epilepsy,
    @diabetes,
    @dentalProsthesis,
    @sunExposure,
    @hypertensive
);

COMMIT;
