SELECT p.ProductName, c.CategoryName
FROM Product p
LEFT JOIN ProductCategory pc ON p.ProductID = pc.ProductID
LEFT JOIN Category c ON pc.CategoryID = c.CategoryID;
ORDER BY P.ProductName, C.CategoryName;
