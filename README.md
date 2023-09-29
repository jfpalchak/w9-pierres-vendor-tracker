# _Pierre's Vendor & Order Tracker_

#### By _Joey Palchak_

#### _An MVC application that tracks vendors and their orders for a fictional bakery._

## Technologies Used

* C#
* HTML
* CSS
* Razor
* .NET 6
* ASP.NET Core MVC
* MSTest

## Description

An MVC application that tracks vendors and their orders for a fictional bakery.

Upon launching the application, the user will be greeted by the project's splash page, where the user can follow a link to *'View List of Vendors'*. This link will route the user to a '/vendors' page, which will initially display *"There are currently no vendors."* as well as two additional links: *'Add a New Vendor'* and *'Back to Home Page'*.

Clicking *'Add a New Vendor'* will route the user to a '/vendors/new' page, which contains a simple form to enter a vendor's Name and Description, a form Submit button, as well as links that go back to the '/vendors' page and the project splash page.

After submitting the Vendor form, the user will be redirected to the '/vendor' homepage with a new link to their freshly added Vendor. The user can choose to add additional vendors to the list, as well as follow a vendor's link.

Following a vendor's link will direct the user to a '/vendors/{vendorId}' page. This page will display the vendor's name and description, as well as the vendor's orders - which will also initially display *"This vendor currently has no orders."*. This page will also present the user with options to *'Add a New Order'*, *'Edit Vendor'*, or go *'Back to Vendors'*.

Clicking *'Add a New Order'* will route the user to a '/vendors/{vendorId}/orders/new' page, which contains a simple form for a vendor's order, with inputs for the order's title, description, price, and date. Upon submitting the order's form, the user will be redirected to the '/vendor/{vendorId}/' page, with a newly populated order list. Clicking on the order will route the user to a '/vendors/{vendorId}/orders/{orderId}' page, which displays the order's details, as well as links to *'Edit Order'*, go *'Back to Orders'*, or go *'Back to Vendors'*.

Should the user click on the *'Edit'* link for either a vendor or a vendor's order, the user will then be presented with the object's respective forms once again; however, the forms will automatically be populated with the vendor's, or order's, current information. The user can chose to change this information and click the *'Update'* button to edit a vendor's, or order's, information, and be redirected to the appropriate page.

Additionally, for both vendor and order edit pages, the user will be presented with the option to *'Delete'* a particular object. Upon clicking a *'Delete'* button, the user will be redirected to the appropriate list page, with the respective object no longer listed.

## Setup/Installation Requirements

1. Copy the **[URL](https://github.com/jfpalchak/w9-pierres-vendor-tracker.git)** provided for this repository.
2. Open Terminal.
3. Change your working directory to where you want the cloned directory.
4. In your terminal, type `git clone` and use the copied URL from Step 1. Or, copy the following git command:
```bash
$ git clone https://github.com/jfpalchak/w9-pierres-vendor-tracker.git
```
5. Open your terminal and navigate to this project's production directory called `VendorTracker`.
6. In the command line, run the following command to compile and launch the web application:
   
```bash
$ dotnet run
```
> Optionally, you can run `dotnet build` to compile this web app without running it.

7. To run tests on the project's models, navigate to the test directory, `VendorTracker.Tests`.
8. In the command line, run the following command to execute tests:
```bash
$ dotnet test
```

## Known Bugs

* If any bugs are discovered, please contact the author.

## License

MIT License

Copyright (c) _9/29/2023_ _Joey Palchak_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.