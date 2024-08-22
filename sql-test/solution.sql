SELECT Products.Name , Categories.Name 
FROM ProductCategories pc 
RIGHT JOIN Categories ON Categories.Id = pc.CategoryId 
RIGHT JOIN Products ON Products.Id = pc.ProductId;