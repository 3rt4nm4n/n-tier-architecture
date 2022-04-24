# n-tier-architecture
N-tier-architecture programming in C# with several layers
A program is divided into logical layers and physical tiers in an N-tier architecture.
Therefore application is programmed in a more organizational way.
Each layer has its own task and responsibilities.
The layers in this project are:
Entity Layer
Business Layer
Data Access Layer
***
Requires Entity Framework to work with.
***
# How To
## 1 - Create a Console Application (.Net Framework)

![console](https://user-images.githubusercontent.com/46112568/164984247-be395883-b39d-48ae-8fdc-40d6d6582f50.PNG)

## 2 - Add required layers as Class Library (.Net Framework) to your project

![classlibrary](https://user-images.githubusercontent.com/46112568/164984267-0d0106d2-d081-4310-ba33-3949b3344b0a.png)

## 3 - Delete default Class.cs in each layer in order to avoid confusion

## 4 - Create an Entities folder in Entity Layer

![entityfolder](https://user-images.githubusercontent.com/46112568/164984301-e52d104f-a848-44b0-81e1-61123f4657d2.png)

## 5 - Add classes such as Products and Categories into the Entities folder

![add_classes](https://user-images.githubusercontent.com/46112568/164984320-167172d7-6761-4be0-902b-94864b3c40ea.png)

## 6 - In your classes define data fields, define an ID datafield as Key with KeyAttribute

![classes](https://user-images.githubusercontent.com/46112568/164984211-fc261361-70ce-46ea-8c0b-3ed6c6a154ad.PNG)

## 7 - Install EntityFramework to the solution (include all layers)

![nuget](https://user-images.githubusercontent.com/46112568/164984396-f866c568-655f-4092-94eb-c8af9e5b5f77.png)

## 8 - Create an Abstract folder in Data Access Layer

![abstract](https://user-images.githubusercontent.com/46112568/164984493-bd517e6a-094d-4a88-b64c-a72f24178226.png)

## 9 - Create interfaces 

![add_interface](https://user-images.githubusercontent.com/46112568/164984528-c2b20fcd-0415-4e0c-ac93-41055c1681bb.png)

![myinterfaces](https://user-images.githubusercontent.com/46112568/164984592-991226c9-2b51-43d1-b72c-f61b82383421.png)

## 10 - Define methods in the IRepository interface file

![define_interface_methods](https://user-images.githubusercontent.com/46112568/164984632-edf1ed2e-674b-4ac9-8fd8-c4915aafe7d7.png)

## 11 - Create a Context class in Data Access Layer and add DbSet methods from DbContext class

![context](https://user-images.githubusercontent.com/46112568/164984786-675fe34d-d040-4b62-914a-180968883f36.png)

## 12 - Create a YourClassNameManager class to the Business Layer

![classmanager](https://user-images.githubusercontent.com/46112568/164984691-66709ade-c227-4b5b-a2c5-8ac5133cf771.png)

## 13 - Add operations related to the layer

![operations](https://user-images.githubusercontent.com/46112568/164984883-fe155b34-7cf4-4bb7-8d56-30bb9a36c9b3.png)

## 14 - Open AppConfig of your program and add the connectionstring to the XML file

![appconfig](https://user-images.githubusercontent.com/46112568/164984981-62e0509e-7c1a-479f-9c93-189cec335755.png)

## 15 - Open Package Manager Console, set Default project and write "enable-migrations" command to the console

![enablemigrations](https://user-images.githubusercontent.com/46112568/164985063-9baf22e2-601b-4adc-ba08-80dc04ce4c64.png)

## 16 - With the previous command working, you will get a Configuration class opened and created in Entity Layer>Migrations

![migrations](https://user-images.githubusercontent.com/46112568/164985153-664aad60-a035-49ef-95cd-b15c3a342b96.png)

## 17 - Change AutomaticMigrationsEnabled to true

![enable](https://user-images.githubusercontent.com/46112568/164985184-1f3e96f3-c53c-4d67-960f-da2cdc619fcd.png)

## 18 - Get back to Package Manager Console and type add-migration, it will ask you to give a name for your migration

![add_migra](https://user-images.githubusercontent.com/46112568/164985222-2f485f39-71ca-4269-bb00-01e4cc53daec.png)

## 19 - When you run the previous command you will get a new class in Migrations folder. The class will be showing your data fields with CreateTable methods

![codefirst](https://user-images.githubusercontent.com/46112568/164985278-74ed1f09-c0bc-4898-99d6-a410054b0fa2.png)

## 20 - Type update-database to the Package Manager Console. Your databse will be created

![update_database](https://user-images.githubusercontent.com/46112568/164985336-c1e8e553-5391-4448-8eeb-76935da90be3.png)

![tables](https://user-images.githubusercontent.com/46112568/164985370-a0ce673d-a9fc-44ed-ab35-716a24f1d74d.png)

![diagram](https://user-images.githubusercontent.com/46112568/164985391-f4e3b545-9c39-4de1-9ec2-45921d9ba0ad.png)

## 21 - Lastly open Program.cs in your presentation layer and type a similar code like in the image to list the items in a table 

![programcs](https://user-images.githubusercontent.com/46112568/164985491-95a441a9-e0d9-44f2-9840-0597a411adda.png)




