select p.name as product_name, c.name as category_name
from product_category
         left join category c on c.id = product_category.category_id
         right join product p on p.id = product_category.product_id