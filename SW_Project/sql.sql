drop table users
CREATE TABLE users(
  user_id number primary key,
  name varchar2(50) not null,
  email varchar2(100) not null,
  password varchar2(100) not null,
  role varchar2(20) not null
)

drop table magazines
create TABLE magazines(
 magazine_id number primary key,
 magazin_title varchar2(100) not null,
 magazin_content varchar2(4000) not null,
 writer_id number not null,
 is_approved number(1) not null,
 foreign key (writer_id) references users(user_id)
)

drop table magazine_categories
create table magazine_categories(
 magazine_id number not null,
 category_name varchar2(50) not null,
 primary key(magazine_id, category_name),
 foreign key (magazine_id) references magazines (magazine_id)
)

drop table reviews
create table reviews (
    review_id number PRIMARY KEY,
    magazine_id number NOT NULL,
    reviewer_id number NOT NULL,
    feedback varchar2(1000),
    FOREIGN KEY (magazine_id) REFERENCES magazines(magazine_id),
    FOREIGN KEY (reviewer_id) REFERENCES users(user_id)
)

--drop table subscriptions
--create table subscriptions (
--    subscription_id number PRIMARY KEY,
--    reader_id number NOT NULL,
--    magazine_id number NOT NULL,
--    FOREIGN KEY (reader_id) REFERENCES users(user_id),
--    FOREIGN KEY (magazine_id) REFERENCES magazines(magazine_id)
--)

drop table favorites
create table favorites (
    reader_id number NOT NULL,
    magazine_id number NOT NULL,
    PRIMARY KEY (reader_id, magazine_id),
    FOREIGN KEY (reader_id) REFERENCES users(user_id),
    FOREIGN KEY (magazine_id) REFERENCES magazines(magazine_id)
)


drop procedure getrow

CREATE OR REPLACE PROCEDURE GetRow(
    Email IN VARCHAR2,
    Password IN VARCHAR2,
    user_Id OUT NUMBER,
    user_Name OUT VARCHAR2
)
IS
BEGIN
    SELECT user_id, name
    INTO user_Id, user_Name
    FROM users
    WHERE email = Email AND password = Password;
END;


