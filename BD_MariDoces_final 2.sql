CREATE DATABASE db_doceria2;
USE db_doceria2;

CREATE TABLE tb_usuarios (
	id_usuario int auto_increment,
    cpf varchar (12) unique,
    nome varchar(50),
    email varchar (150) unique,
    senha varchar (50)unique,
    primary key (id_usuario)
    );
 
CREATE TABLE tb_categorias (
	id_categoria int auto_increment,
    nome_categoria varchar(20) unique,
    
    primary key (id_categoria)
);

CREATE TABLE tb_sabores (
	id_sabor int auto_increment,
	nome_sabor varchar(20) unique,
    
    primary key (id_sabor)
);

CREATE TABLE tb_produtos (
	id_produto int auto_increment,
    
    imagem varchar (200),
    nome varchar (20),
    descricao varchar (200),
    valor decimal (6,2),
    promocao bool,
    
    id_categoria int,
	id_sabor int,
    
    primary key (id_produto),
    foreign key (id_categoria) references tb_categorias(id_categoria),
	foreign key (id_sabor) references tb_sabores(id_sabor)
);




INSERT INTO tb_usuarios (cpf, nome, email, senha) VALUES 
('1', 'Mariana', 'Mariana@email.com', 'senha123'),
('8', 'Felipe', 'felipe@email.com', 'se123');
 SELECT * FROM tb_usuarios;
 
INSERT INTO tb_categorias (nome_categoria) VALUES
('Bolo de pote'),
('Bolo de festa'),
('Brigadeiros'),
('Trufas'),
('Brownie'),
('Pâo de mel'),
('Bebidas');
 SELECT * FROM tb_categorias;
 
INSERT INTO tb_sabores (nome_sabor) VALUES 
('Chocolate'),
('Morango'),
('Abacaxi'),
('Maracujá'),
('Prestígio'),
('Paçoca'),
('Côco com Abacaxi'),
('Cenoura com chocolate'),
('Laranja'),
('Beijinho'),
('Bicho de pé'),
('Black'),
('Café'),
('Ninho com Nutella'),
('Churros'),
('Ferrero Rocher'),
('Oreo'),
('Torta de Limão'),
('Surpresa de Uva'),
('Red Velvet'),
('Cacau, côco e avelã'),
('Ninho com Morango'),
('Nutella'),
('Doce de Leite'),
('Amêndoas'),
('Sem recheio'),
('Pasta de Amendoim'),
('Água'),
('Café com Leite'),
('Capuccino'),
('Chá Mate'),
('Cola-Cola'),
('Guaraná'),
('Sprite');
 SELECT * FROM tb_sabores;
 
/*SELECTs -> */
 SELECT * FROM tb_usuarios;
 SELECT * FROM tb_categorias;
 SELECT * FROM tb_sabores;
 SELECT * FROM tb_produtos;
 
INSERT INTO tb_produtos (imagem, nome, descricao, valor, promocao, id_categoria, id_sabor)
VALUES 
/*Bolos de Pote ->*/
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolosDePote/Frame%209%20(2).png', 'Chocolate', '.', 10.00, FALSE, 1, 1),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolosDePote/Frame%209%20(3).png', 'Maracujá', 'Massa Chocolate', 10.00, FALSE, 1, 4),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolosDePote/Frame%209%20(4).png', 'Maracujá', 'Massa Branca', 10.00, FALSE, 1, 4),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolosDePote/Frame%209%20(6).png', 'Morango', 'Massa Chocolate', 10.00, FALSE, 1, 2),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolosDePote/Frame%209%20(5).png', 'Morango', 'Massa Branca', 10.00, FALSE, 1, 2),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolosDePote/Frame%209%20(7).png', 'Abacaxi', '.', 10.00, FALSE, 1, 3),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolosDePote/Frame%209%20(8).png', 'Prestígio', '.', 10.00, FALSE, 1, 5),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/bolodepote4.png', 'Morango', 'Low Carb', 10.00, FALSE, 1, 2),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/bolodepote3.png', 'Paçoca', 'Low Carb', 10.00, FALSE, 1, 6),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/boodepote2.png', 'Côco com Abacaxi', 'Low Carb', 10.00, FALSE, 1, 7),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/bolodepode1.png', 'Cenoura com Chocolate', 'Low Carb', 10.00, TRUE, 1, 8),
/*Bolos de Festas ->*/
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolos/Frame%209%20(2).png', 'Chocolate', '.', 80.00, FALSE, 2, 1),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolos/Frame%209%20(3).png', 'Maracujá', 'Massa Chocolate', 80.00, FALSE, 2, 4),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolos/Frame%209%20(4).png', 'Maracujá', 'Massa Branca', 80.00, FALSE, 2, 4),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolos/Frame%209%20(6).png', 'Morango', 'Massa Chocolate', 80.00, FALSE, 2, 2),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolos/Frame%209%20(5).png', 'Morango', 'Massa Branca', 80.00, FALSE, 2, 2),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolos/Frame%209%20(7).png', 'Abacaxi', '.', 80.00, FALSE, 2, 3),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolos/Frame%209%20(1).png', 'Prestígio', '.', 80.00, FALSE, 2, 5),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/bolo1.png', 'Morango', '.', 80.00, FALSE, 2, 2),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/bolo2.png', 'Prestígio', '.', 80.00, FALSE, 2, 5),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/bolo3.png', 'Laranja', '.', 80.00, TRUE, 2, 9),
/*Brigadeiros ->*/
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(13).png', 'Chocolate', '.', 1.50, FALSE, 3, 1),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(12).png', 'Beijinho', '.', 1.50, FALSE, 3, 10),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(11).png', 'Bicho de Pé', '.', 2.50, FALSE, 3, 11),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20.png', 'Black', '.', 2.50, FALSE, 3, 12),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(10).png', 'Café', '.', 2.50, FALSE, 3, 13),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(1).png', 'Ninho com Nutella', '.', 2.50, FALSE, 3, 14),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(9).png', 'Churros', '.', 2.50, FALSE, 3, 15),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(8).png', 'Ferrero Rocher', '.', 3.00, FALSE, 3, 16),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(7).png', 'Maracujá', '.', 3.00, FALSE, 3, 4),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(6).png', 'Oreo', '.', 3.00, FALSE, 3, 17),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(5).png', 'Torta de Limão', '.', 3.00, FALSE, 3, 18),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(4).png', 'Paçoca', '.', 2.50, FALSE, 3, 6),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(3).png', 'Surpresa de Uva', '.', 2.50, FALSE, 3, 19),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(2).png', 'Red Velvet', '.', 3.00, FALSE, 3, 20),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/brigadeiro1.png', 'Cacau, Côco e Avelã', 'Low Carb', 3.00, FALSE, 3, 21),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/brigadeiro2.png', 'Chocolate', 'Low Carb', 3.00, TRUE, 3, 1),
/*Trufas ->*/
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_trufas/Frame%209%20(5).png', 'Ferrero Rocher', '.', 5.00, FALSE, 4, 16),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_trufas/Frame%209%20(6).png', 'Morango', '.', 5.00, FALSE, 4, 2),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_trufas/Frame%209%20(4).png', 'Chocolate', '.', 5.00, FALSE, 4, 1),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_trufas/Frame%209%20(3).png', 'Maracujá', '.', 5.00, FALSE, 4, 4),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_trufas/Frame%209%20(2).png', 'Prestígio', '.', 5.00, FALSE, 4, 5),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/trufa.png', 'Chocolate', 'Low Carb', 5.00, TRUE, 4, 1),
/*Brownie ->*/
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brownies/Frame%209%20(2).png', 'Sem Recheio', '.', 5.00, FALSE, 5, 26),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brownies/Frame%209%20(3).png', 'Chocolate', '.', 7.00, FALSE, 5, 1),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brownies/Frame%209%20(4).png', 'Ninho com Morango', '.', 7.00, FALSE, 5, 22),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brownies/Frame%209%20(5).png', 'Prestígio', '.', 7.00, FALSE, 5, 5),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brownies/Frame%209%20(6).png', 'Nutella', '.', 7.00, FALSE, 5, 23),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brownies/Frame%209%20(7).png', 'Doce de Leite', '.', 7.00, FALSE, 5, 24),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/brownie.png', 'Amêndoas', 'Low Carb', 7.00, TRUE, 5, 25),
/*Pão de Mel ->*/
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_paesdemel/Frame%209%20(4).png', 'Doce de Leite', '.', 8.00, FALSE, 6, 1),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_paesdemel/Frame%209%20(3).png', 'Prestígio', '.', 8.00, FALSE, 6, 1),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_paesdemel/Frame%209%20(2).png', 'Chocolate', '.', 8.00, FALSE, 6, 1),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/paodemel.png', 'Pasta de Amendoim', 'Low Carb', 8.00, TRUE, 6, 1),
/*Bebidas ->*/
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(12).png', 'Água', '.', 3.00, FALSE, 7, 28),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(2).png', 'Café', '.', 5.00, FALSE, 7, 13),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(4).png', 'Café com Leite', '.', 6.00, FALSE, 7, 29),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(3).png', 'Cappuccino', '.', 7.00, FALSE, 7, 30),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(5).png', 'Chá Mate', '.', 6.00, FALSE, 7, 31),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(6).png', 'Coca-Cola', '.', 8.00, FALSE, 7, 32),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(7).png', 'Guaraná Antartica', '.', 8.00, FALSE, 7, 33),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(8).png', 'Sprite', '.', 8.00, FALSE, 7, 34),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(9).png', 'Suco de Laranja', '.', 9.00, FALSE, 7, 9),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(11).png', 'Suco de Maracujá', '.', 9.00, FALSE, 7, 4),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(10).png', 'Suco de Abacaxi', '.', 9.00, TRUE, 7, 3)
;

SELECT * FROM tb_produtos;






/* comentarios-------------------------------------------------------*/

/* 
DROP TABLE tb_usuarios;
DROP TABLE tb_produtos;
DROP TABLE tb_categorias;
DROP TABLE tb_sabores;
DROP TABLE tb_promocoes;

DELETE FROM tb_;
DROP TABLE tb_;
TRUNCATE TABLE tb_;
 
SELECT * FROM tb_sabores;
SELECT DISTINCT nome_sabor FROM tb_sabores;
 
DELETE FROM tb_bebidas WHERE id_bebida > 12; 
 
SELECT * FROM tb_sabores;
SELECT DISTINCT nome_sabor FROM tb_sabores;
DELETE FROM tb_sabores WHERE id_sabor > 27;
ALTER TABLE tb;

SELECT tb_produtos.*, tb_categorias.nome_categoria FROM tb_produtos
INNER JOIN tb_categorias ON tb_produtos.id_categoria = tb_categorias.id_categoria;

/*SELECT * FROM tb_produtos 
INNER JOIN tb_categorias ON id_categoria = 
WHERE quantidade > 0 
*/
 
/*-----------------------tabelas possivelmente apagadas--------------------------------------*/
/*CREATE TABLE tb_nf_pagamentos(
	id_pagamento varchar(20),
    status_pagamento varchar(20),
	forma_de_pagamento varchar(20),
   /* id_nota_fiscal varchar(20),*/
    
	/*primary key (id_pagamento)
    /*foreign key (id_nota_fiscal) references tb_notas_fiscais(id_nota_fiscal)
);*/

/*CREATE TABLE tb_notas_fiscais(
	id_nota_fiscal varchar(20),
    
	valor_total decimal (6,2),
    forma_de_pagamento varchar(20),
	/*status_pagamento varchar(20),
    
	id_usuario varchar(20),
    /*id_item varchar(20),
	
    primary key (id_nota_fiscal),
	foreign key (id_usuario) references tb_usuarios(id_usuario)
    /*foreign key (id_item) references tb_nf_item(id_item)
);

CREATE TABLE tb_nf_item(
	id_nf_item int auto_increment,
    
    quantidade_produto int(4),
	id_produto int,
    id_nota_fiscal varchar(20),
    
	primary key (id_nf_item),
	foreign key (id_produto) references tb_produtos(id_produto),
    foreign key (id_nota_fiscal) references tb_notas_fiscais(id_nota_fiscal)
);*/

 /*
CREATE TABLE tb_promocoes (
	id_promocao bool,
    
    id_produto int,
    
    primary key (id_promocao),
    foreign key (id_produto) references tb_produtos(id_produto)
);*/

