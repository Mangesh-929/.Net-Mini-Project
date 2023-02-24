### **Title**: CRUD operations on product using Entity Framework core.
### **Description**:
This project involves performing CRUD (Create, Read, Update, Delete) operations on products using the .NET MVC (Model-View-Controller) framework. The project is designed to allow users to manage product information easily and efficiently.
The project has a user interface that is developed using HTML, CSS, and JavaScript. The user interface is designed to allow users to interact with the product information stored in the database. The interface provides users with a form to add new products to the database, a table to view existing products, a form to edit existing products, and a delete button to remove products from the database.
### **Approach**:
The project is built using the Model-View-Controller (MVC) architecture, which separates the application's concerns into three main components: the model, which represents the data and business logic; the view, which represents the user interface; and the controller, which handles user input and manages communication between the model and view.
The project has a database that stores information about the products. The database is connected to the .NET MVC framework using Entity Framework. This allows the framework to access the database and perform the CRUD operations.

### **Features**:
```
Index Page: The Index page of the application displays a list of all products in the database, along with options to add, update and delete product.
AddProduct Page: The AddNewProduct operation allows users to add new products to the database. Users can enter the product name, description, price, and other details into a form. When the user clicks the submit button, the product information is sent to the server, and a new product record is created in the database.
UpdateProduct Page: The UpdateProduct operation allows users to modify existing products in the database. Users can select a product from the table and click the edit button. This opens a form where the user can modify the product information. When the user clicks the submit button, the product record in the database is updated with the new information.
Delete Functionality: The DeleteProduct operation allows users to remove products from the database. Users can click on a delete product button to delete a product from the database.
```


### **Tech Stack**:
```
ASP.NET MVC Framework
Microsoft SQL Server
Entity Framework
```

### **Demo**:
Index Page
![Screenshot (1756)](https://user-images.githubusercontent.com/122014047/221113600-02cc9961-bfcb-49eb-bc84-358527209805.png)

Update Page
![Screenshot (1757)](https://user-images.githubusercontent.com/122014047/221113800-14a5c63b-b247-4bf5-b7b3-04640e1635fe.png)

Add Page
![Screenshot (1758)](https://user-images.githubusercontent.com/122014047/221113943-0c061ca0-aebd-47de-a5df-0eb7e238f580.png)

Delete
![Screenshot (1756)](https://user-images.githubusercontent.com/122014047/221114086-81283ae5-aac0-4d68-a145-c704cf925459.png)

