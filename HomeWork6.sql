
-- Задание №1

CREATE TABLE users_old as (select * from users where 0=1)

DROP PROCEDURE IF exists user_to_old_table;

DELIMITER // 

CREATE PROCEDURE user_in_old_table(user_id int)
begin
START TRANSACTION
INSERT INTO users_old SELECT * FROM users WHERE id = user_id
DELETE FROM users WHERE users.id = user_id
	IF (ROW_COUNT > 0) THEN
	commit
	SELECT 'Пользователь успешно перемещен в таблицу users_old'
	ELSE
	rollback
	SELECT 'Не удалось переместить пользователя․ Пользователь с таким id не найден в таблице users'
	end if
COMMIT
end //

DELIMITER ;

call user_in_old_table(2)

SELECT * FROM users_old

-- Задание №2

CREATE TABLE greeting_time (
time_start TIME,
time_end TIME,
greeting TEXT
);

INSERT INTO greeting_time (time_start, time_end, greeting)
VALUES
('06⁚00⁚00', '12⁚00⁚00', 'Доброе утро'),
('12⁚00⁚01', '18⁚00⁚00', 'Добрый день'),
('18⁚00⁚01', '23⁚59⁚59', 'Добрый вечер'),
('00⁚00⁚00', '05⁚59⁚59', 'Доброй ночи');

DELIMITER //

CREATE FUNCTION hello RETURNS TEXT
BEGIN
DECLARE current_time TIME;
DECLARE greeting_text TEXT;
SET current_time CURTIME;

SELECT greeting INTO greeting_text
FROM greeting_time 
WHERE current_time BETWEEN time_start AND time_end;

RETURN greeting_text; 
END //

DELIMITER ;

SELECT hello;