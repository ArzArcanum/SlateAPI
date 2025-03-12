DROP DATABASE IF EXISTS slate_db;
CREATE DATABASE IF NOT EXISTS slate_db;

USE slate_db;

CREATE TABLE messages (
    id BIGINT PRIMARY KEY AUTO_INCREMENT,
    user_id VARCHAR(50) NOT NULL,
    content TEXT NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO messages (user_id, content, created_at)
VALUES
    ('2', 'Hello', NOW()),
    ('2', 'How are you today?', NOW()),
    ('3', 'I''m fine thanks', NOW());
    
SELECT * FROM messages;
