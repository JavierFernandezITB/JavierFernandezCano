/*

    1. Crea un bloc anònim que ha d'imprimir el cognom de l'empleat en majúscules amb codi
    número 104 de la taula (EMPLOYEES), on has de declarar una variable de tipus last_name.

*/

DO $$
DECLARE
    apellido employees.last_name%TYPE;
BEGIN
    SELECT last_name
    INTO apellido
    FROM employees
    WHERE employee_id = 104;
    raise notice 'El apellido es %', UPPER(apellido);
END;
$$

/*

    2. Crea un bloc anònim que ha d'imprimir el cognom de l'empleat en majúscules del id de
    l’empleat introdueixi per pantalla.

*/

DO $$
DECLARE
    apellido employees.last_name%TYPE;
BEGIN
    SELECT last_name
    INTO apellido
    FROM employees
    WHERE employee_id = :"Introduce la ID del empleado";
    raise notice 'El apellido es %', UPPER(apellido);
END;
$$