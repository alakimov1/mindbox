--Подразуменвается 3 таблицы: продукты(id,name), категории(id,name) и таблица из связи(product_id, category_id)
SELECT p.name as product, c.name as category
FROM products p
LEFT JOIN products_categories p_c
ON p.id = p_c.product_id
LEFT JOIN categories c
ON p_c.category_id = c.id;
