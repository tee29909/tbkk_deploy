using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tbkk.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    BrandID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.BrandID);
                });

            migrationBuilder.CreateTable(
                name: "Canteen",
                columns: table => new
                {
                    CanteenID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Line = table.Column<string>(nullable: true),
                    Call = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canteen", x => x.CanteenID);
                });

            migrationBuilder.CreateTable(
                name: "CarType_Cock",
                columns: table => new
                {
                    CarType_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CerNumber = table.Column<int>(nullable: false),
                    NameCar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarType_Cock", x => x.CarType_CockID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Company_Cock",
                columns: table => new
                {
                    Company_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company_Cock", x => x.Company_CockID);
                });

            migrationBuilder.CreateTable(
                name: "CompanyCar",
                columns: table => new
                {
                    CompanyCarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCompanyCar = table.Column<string>(nullable: true),
                    Seat = table.Column<string>(nullable: true),
                    Line = table.Column<string>(nullable: true),
                    Call = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCar", x => x.CompanyCarID);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Department_Cock",
                columns: table => new
                {
                    Department_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department_Cock", x => x.Department_CockID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeType",
                columns: table => new
                {
                    EmployeeTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeType", x => x.EmployeeTypeID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeType_Cock",
                columns: table => new
                {
                    EmployeeType_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeType_Cock", x => x.EmployeeType_CockID);
                });

            migrationBuilder.CreateTable(
                name: "FoodSet_Cock",
                columns: table => new
                {
                    FoodSet_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manu = table.Column<string>(nullable: true),
                    NameSet = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodSet_Cock", x => x.FoodSet_CockID);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "Network",
                columns: table => new
                {
                    NetworkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NetworkName = table.Column<string>(nullable: true),
                    IpAddr = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Network", x => x.NetworkID);
                });

            migrationBuilder.CreateTable(
                name: "OT",
                columns: table => new
                {
                    OTID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    TimeEnd = table.Column<DateTime>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    TypeOT = table.Column<string>(nullable: true),
                    TypStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OT", x => x.OTID);
                });

            migrationBuilder.CreateTable(
                name: "OT_Cock",
                columns: table => new
                {
                    OT_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    TypeOT = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OT_Cock", x => x.OT_CockID);
                });

            migrationBuilder.CreateTable(
                name: "Part",
                columns: table => new
                {
                    PartID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part", x => x.PartID);
                });

            migrationBuilder.CreateTable(
                name: "Part_Cock",
                columns: table => new
                {
                    Part_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part_Cock", x => x.Part_CockID);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    PositionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.PositionID);
                });

            migrationBuilder.CreateTable(
                name: "Position_Cock",
                columns: table => new
                {
                    Position_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position_Cock", x => x.Position_CockID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier_Cock",
                columns: table => new
                {
                    Supplier_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier_Cock", x => x.Supplier_CockID);
                });

            migrationBuilder.CreateTable(
                name: "FoodSet",
                columns: table => new
                {
                    FoodSetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodSetcoManul = table.Column<string>(nullable: true),
                    NameSet = table.Column<string>(nullable: true),
                    Canteen_CanteenID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodSet", x => x.FoodSetID);
                    table.ForeignKey(
                        name: "FK_FoodSet_Canteen_Canteen_CanteenID",
                        column: x => x.Canteen_CanteenID,
                        principalTable: "Canteen",
                        principalColumn: "CanteenID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    ModelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(nullable: true),
                    Model_BrandIDBrandID = table.Column<int>(nullable: true),
                    Model_CategoryIDCategoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.ModelID);
                    table.ForeignKey(
                        name: "FK_Models_Brand_Model_BrandIDBrandID",
                        column: x => x.Model_BrandIDBrandID,
                        principalTable: "Brand",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Models_Category_Model_CategoryIDCategoryID",
                        column: x => x.Model_CategoryIDCategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarType",
                columns: table => new
                {
                    CarTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCar = table.Column<string>(nullable: true),
                    Seat = table.Column<int>(nullable: false),
                    CompanyCarID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarType", x => x.CarTypeID);
                    table.ForeignKey(
                        name: "FK_CarType_CompanyCar_CompanyCarID",
                        column: x => x.CompanyCarID,
                        principalTable: "CompanyCar",
                        principalColumn: "CompanyCarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Point",
                columns: table => new
                {
                    PointID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePoint = table.Column<string>(nullable: true),
                    Point_PartIDPartID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Point", x => x.PointID);
                    table.ForeignKey(
                        name: "FK_Point_Part_Point_PartIDPartID",
                        column: x => x.Point_PartIDPartID,
                        principalTable: "Part",
                        principalColumn: "PartID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Line = table.Column<string>(nullable: true),
                    Call = table.Column<string>(nullable: true),
                    Addr = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Employee_CompanyID = table.Column<int>(nullable: false),
                    Employee_DepartmentID = table.Column<int>(nullable: false),
                    Employee_LocationID = table.Column<int>(nullable: false),
                    Employee_EmployeeTypeID = table.Column<int>(nullable: false),
                    Employee_PositionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employee_Company_Employee_CompanyID",
                        column: x => x.Employee_CompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Department_Employee_DepartmentID",
                        column: x => x.Employee_DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_EmployeeType_Employee_EmployeeTypeID",
                        column: x => x.Employee_EmployeeTypeID,
                        principalTable: "EmployeeType",
                        principalColumn: "EmployeeTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Location_Employee_LocationID",
                        column: x => x.Employee_LocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Position_Employee_PositionID",
                        column: x => x.Employee_PositionID,
                        principalTable: "Position",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Cock",
                columns: table => new
                {
                    Employee_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CompanyIDCompany_CockID = table.Column<int>(nullable: true),
                    DepartmentNameDepartment_CockID = table.Column<int>(nullable: true),
                    EmployeeType_CockID = table.Column<int>(nullable: true),
                    PositionIDPosition_CockID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Cock", x => x.Employee_CockID);
                    table.ForeignKey(
                        name: "FK_Employee_Cock_Company_Cock_CompanyIDCompany_CockID",
                        column: x => x.CompanyIDCompany_CockID,
                        principalTable: "Company_Cock",
                        principalColumn: "Company_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Cock_Department_Cock_DepartmentNameDepartment_CockID",
                        column: x => x.DepartmentNameDepartment_CockID,
                        principalTable: "Department_Cock",
                        principalColumn: "Department_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Cock_EmployeeType_Cock_EmployeeType_CockID",
                        column: x => x.EmployeeType_CockID,
                        principalTable: "EmployeeType_Cock",
                        principalColumn: "EmployeeType_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Cock_Position_Cock_PositionIDPosition_CockID",
                        column: x => x.PositionIDPosition_CockID,
                        principalTable: "Position_Cock",
                        principalColumn: "Position_CockID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "License",
                columns: table => new
                {
                    LicenseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicenseName = table.Column<string>(nullable: true),
                    SoftewareName = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    PONumber = table.Column<string>(nullable: true),
                    Attachfiles = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    License_ModelIDModelID = table.Column<int>(nullable: true),
                    License_SupplierIDSupplierID = table.Column<int>(nullable: true),
                    License_DepartmentIDDepartmentID = table.Column<int>(nullable: true),
                    License_CompanyIDCompanyID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_License", x => x.LicenseID);
                    table.ForeignKey(
                        name: "FK_License_Company_License_CompanyIDCompanyID",
                        column: x => x.License_CompanyIDCompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_License_Department_License_DepartmentIDDepartmentID",
                        column: x => x.License_DepartmentIDDepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_License_Models_License_ModelIDModelID",
                        column: x => x.License_ModelIDModelID,
                        principalTable: "Models",
                        principalColumn: "ModelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_License_Supplier_License_SupplierIDSupplierID",
                        column: x => x.License_SupplierIDSupplierID,
                        principalTable: "Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarQueue",
                columns: table => new
                {
                    CarQueueID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarNumber = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    CarQueue_OTID = table.Column<int>(nullable: false),
                    CarQueue_CarTypeID = table.Column<int>(nullable: false),
                    CarQueue_PartID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarQueue", x => x.CarQueueID);
                    table.ForeignKey(
                        name: "FK_CarQueue_CarType_CarQueue_CarTypeID",
                        column: x => x.CarQueue_CarTypeID,
                        principalTable: "CarType",
                        principalColumn: "CarTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarQueue_OT_CarQueue_OTID",
                        column: x => x.CarQueue_OTID,
                        principalTable: "OT",
                        principalColumn: "OTID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarQueue_Part_CarQueue_PartID",
                        column: x => x.CarQueue_PartID,
                        principalTable: "Part",
                        principalColumn: "PartID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    AssetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetName = table.Column<string>(nullable: true),
                    SerailNumber = table.Column<string>(nullable: true),
                    MACAddr = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    PONumber = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Asset_LocationIDLocationID = table.Column<int>(nullable: true),
                    Asset_CompanyIDCompanyID = table.Column<int>(nullable: true),
                    Asset_DepartmentIDDepartmentID = table.Column<int>(nullable: true),
                    Asset_SupplierIDSupplierID = table.Column<int>(nullable: true),
                    Asset_EmployeeIDEmployeeID = table.Column<int>(nullable: true),
                    Asset_ModelIDModelID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.AssetID);
                    table.ForeignKey(
                        name: "FK_Asset_Company_Asset_CompanyIDCompanyID",
                        column: x => x.Asset_CompanyIDCompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Department_Asset_DepartmentIDDepartmentID",
                        column: x => x.Asset_DepartmentIDDepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Employee_Asset_EmployeeIDEmployeeID",
                        column: x => x.Asset_EmployeeIDEmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Location_Asset_LocationIDLocationID",
                        column: x => x.Asset_LocationIDLocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Models_Asset_ModelIDModelID",
                        column: x => x.Asset_ModelIDModelID,
                        principalTable: "Models",
                        principalColumn: "ModelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Supplier_Asset_SupplierIDSupplierID",
                        column: x => x.Asset_SupplierIDSupplierID,
                        principalTable: "Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetailOT",
                columns: table => new
                {
                    DetailOTID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    TimeEnd = table.Column<DateTime>(nullable: false),
                    Hour = table.Column<TimeSpan>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Part_PaetID = table.Column<int>(nullable: false),
                    FoodSet_FoodSetID = table.Column<int>(nullable: false),
                    OT_OTID = table.Column<int>(nullable: false),
                    Employee_EmpID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailOT", x => x.DetailOTID);
                    table.ForeignKey(
                        name: "FK_DetailOT_Employee_Employee_EmpID",
                        column: x => x.Employee_EmpID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailOT_FoodSet_FoodSet_FoodSetID",
                        column: x => x.FoodSet_FoodSetID,
                        principalTable: "FoodSet",
                        principalColumn: "FoodSetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailOT_OT_OT_OTID",
                        column: x => x.OT_OTID,
                        principalTable: "OT",
                        principalColumn: "OTID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailOT_Part_Part_PaetID",
                        column: x => x.Part_PaetID,
                        principalTable: "Part",
                        principalColumn: "PartID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GradeHistory",
                columns: table => new
                {
                    GradeHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrahAllPoint = table.Column<int>(nullable: false),
                    GrahBonus = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    GrahSalaryUp = table.Column<int>(nullable: false),
                    GrahYear = table.Column<DateTime>(nullable: false),
                    GradeHistory_EmployeeIDEmployeeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeHistory", x => x.GradeHistoryID);
                    table.ForeignKey(
                        name: "FK_GradeHistory_Employee_GradeHistory_EmployeeIDEmployeeID",
                        column: x => x.GradeHistory_EmployeeIDEmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    LoginID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Login_EmployeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.LoginID);
                    table.ForeignKey(
                        name: "FK_Login_Employee_Login_EmployeeID",
                        column: x => x.Login_EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UpdateNetwork",
                columns: table => new
                {
                    UpdateNetworkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    IpAddr = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UpdateNetwork_EmployeeIDEmployeeID = table.Column<int>(nullable: true),
                    UpdateNetwork_NetworkIDNetworkID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdateNetwork", x => x.UpdateNetworkID);
                    table.ForeignKey(
                        name: "FK_UpdateNetwork_Employee_UpdateNetwork_EmployeeIDEmployeeID",
                        column: x => x.UpdateNetwork_EmployeeIDEmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateNetwork_Network_UpdateNetwork_NetworkIDNetworkID",
                        column: x => x.UpdateNetwork_NetworkIDNetworkID,
                        principalTable: "Network",
                        principalColumn: "NetworkID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asset_Cock",
                columns: table => new
                {
                    Asset_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetName = table.Column<string>(nullable: true),
                    SerailNumber = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    DepartmentIDDepartment_CockID = table.Column<int>(nullable: true),
                    CompanyIDCompany_CockID = table.Column<int>(nullable: true),
                    SupplierIDSupplier_CockID = table.Column<int>(nullable: true),
                    EmployeeIDEmployee_CockID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset_Cock", x => x.Asset_CockID);
                    table.ForeignKey(
                        name: "FK_Asset_Cock_Company_Cock_CompanyIDCompany_CockID",
                        column: x => x.CompanyIDCompany_CockID,
                        principalTable: "Company_Cock",
                        principalColumn: "Company_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Cock_Department_Cock_DepartmentIDDepartment_CockID",
                        column: x => x.DepartmentIDDepartment_CockID,
                        principalTable: "Department_Cock",
                        principalColumn: "Department_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Cock_Employee_Cock_EmployeeIDEmployee_CockID",
                        column: x => x.EmployeeIDEmployee_CockID,
                        principalTable: "Employee_Cock",
                        principalColumn: "Employee_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asset_Cock_Supplier_Cock_SupplierIDSupplier_CockID",
                        column: x => x.SupplierIDSupplier_CockID,
                        principalTable: "Supplier_Cock",
                        principalColumn: "Supplier_CockID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetailOT_Cock",
                columns: table => new
                {
                    DetailOT_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hour = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    CarNumber = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    EmployeeIDEmployee_CockID = table.Column<int>(nullable: true),
                    PartIDPart_CockID = table.Column<int>(nullable: true),
                    CarType_CockID = table.Column<int>(nullable: true),
                    FoodSet_CockID = table.Column<int>(nullable: true),
                    OTIDOT_CockID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailOT_Cock", x => x.DetailOT_CockID);
                    table.ForeignKey(
                        name: "FK_DetailOT_Cock_CarType_Cock_CarType_CockID",
                        column: x => x.CarType_CockID,
                        principalTable: "CarType_Cock",
                        principalColumn: "CarType_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailOT_Cock_Employee_Cock_EmployeeIDEmployee_CockID",
                        column: x => x.EmployeeIDEmployee_CockID,
                        principalTable: "Employee_Cock",
                        principalColumn: "Employee_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailOT_Cock_FoodSet_Cock_FoodSet_CockID",
                        column: x => x.FoodSet_CockID,
                        principalTable: "FoodSet_Cock",
                        principalColumn: "FoodSet_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailOT_Cock_OT_Cock_OTIDOT_CockID",
                        column: x => x.OTIDOT_CockID,
                        principalTable: "OT_Cock",
                        principalColumn: "OT_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailOT_Cock_Part_Cock_PartIDPart_CockID",
                        column: x => x.PartIDPart_CockID,
                        principalTable: "Part_Cock",
                        principalColumn: "Part_CockID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GradeHistory_Cock",
                columns: table => new
                {
                    GradeHistory_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrahAllPoint = table.Column<int>(nullable: false),
                    GrahBonus = table.Column<int>(nullable: false),
                    GrahSalaryUp = table.Column<int>(nullable: false),
                    GrahYear = table.Column<DateTime>(nullable: false),
                    EmployeeIDEmployee_CockID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeHistory_Cock", x => x.GradeHistory_CockID);
                    table.ForeignKey(
                        name: "FK_GradeHistory_Cock_Employee_Cock_EmployeeIDEmployee_CockID",
                        column: x => x.EmployeeIDEmployee_CockID,
                        principalTable: "Employee_Cock",
                        principalColumn: "Employee_CockID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UpdateLicense",
                columns: table => new
                {
                    UpdateLicenseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    LicenseName = table.Column<string>(nullable: true),
                    SoftwareName = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    PONumber = table.Column<string>(nullable: true),
                    Attachfiles = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    UpdateLicense_ModelIDModelID = table.Column<int>(nullable: true),
                    UpdateLicense_SupplierIDSupplierID = table.Column<int>(nullable: true),
                    UpdateLicense_DepartmentIDDepartmentID = table.Column<int>(nullable: true),
                    UpdateLicense_CompanyIDCompanyID = table.Column<int>(nullable: true),
                    UpdateLicense_LicenseIDLicenseID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdateLicense", x => x.UpdateLicenseID);
                    table.ForeignKey(
                        name: "FK_UpdateLicense_Company_UpdateLicense_CompanyIDCompanyID",
                        column: x => x.UpdateLicense_CompanyIDCompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateLicense_Department_UpdateLicense_DepartmentIDDepartmentID",
                        column: x => x.UpdateLicense_DepartmentIDDepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateLicense_License_UpdateLicense_LicenseIDLicenseID",
                        column: x => x.UpdateLicense_LicenseIDLicenseID,
                        principalTable: "License",
                        principalColumn: "LicenseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateLicense_Models_UpdateLicense_ModelIDModelID",
                        column: x => x.UpdateLicense_ModelIDModelID,
                        principalTable: "Models",
                        principalColumn: "ModelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateLicense_Supplier_UpdateLicense_SupplierIDSupplierID",
                        column: x => x.UpdateLicense_SupplierIDSupplierID,
                        principalTable: "Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetailCarQueue",
                columns: table => new
                {
                    DetailCarQueueID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailCarQueue_EmployeeID = table.Column<int>(nullable: false),
                    DetailCarQueue_CarQueueID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailCarQueue", x => x.DetailCarQueueID);
                    table.ForeignKey(
                        name: "FK_DetailCarQueue_CarQueue_DetailCarQueue_CarQueueID",
                        column: x => x.DetailCarQueue_CarQueueID,
                        principalTable: "CarQueue",
                        principalColumn: "CarQueueID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailCarQueue_Employee_DetailCarQueue_EmployeeID",
                        column: x => x.DetailCarQueue_EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssetJoinNetworks",
                columns: table => new
                {
                    AssetJoinNetworkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    AssetJoinNetwork_NetworkIDNetworkID = table.Column<int>(nullable: true),
                    AssetJoinNetwork_AssetIDAssetID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetJoinNetworks", x => x.AssetJoinNetworkID);
                    table.ForeignKey(
                        name: "FK_AssetJoinNetworks_Asset_AssetJoinNetwork_AssetIDAssetID",
                        column: x => x.AssetJoinNetwork_AssetIDAssetID,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetJoinNetworks_Network_AssetJoinNetwork_NetworkIDNetworkID",
                        column: x => x.AssetJoinNetwork_NetworkIDNetworkID,
                        principalTable: "Network",
                        principalColumn: "NetworkID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JoinAssetEmp",
                columns: table => new
                {
                    JoinAssetEmpID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    JoinAssetEmp_EmployeeIDEmployeeID = table.Column<int>(nullable: true),
                    JoinAssetEmp_AssetIDAssetID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinAssetEmp", x => x.JoinAssetEmpID);
                    table.ForeignKey(
                        name: "FK_JoinAssetEmp_Asset_JoinAssetEmp_AssetIDAssetID",
                        column: x => x.JoinAssetEmp_AssetIDAssetID,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JoinAssetEmp_Employee_JoinAssetEmp_EmployeeIDEmployeeID",
                        column: x => x.JoinAssetEmp_EmployeeIDEmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JoinLicenseAsset",
                columns: table => new
                {
                    JoinLicenseAssetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true),
                    JoinLicenseAsset_LicenseLicenseID = table.Column<int>(nullable: true),
                    JoinLicenseAsset_AssetIDAssetID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinLicenseAsset", x => x.JoinLicenseAssetID);
                    table.ForeignKey(
                        name: "FK_JoinLicenseAsset_Asset_JoinLicenseAsset_AssetIDAssetID",
                        column: x => x.JoinLicenseAsset_AssetIDAssetID,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JoinLicenseAsset_License_JoinLicenseAsset_LicenseLicenseID",
                        column: x => x.JoinLicenseAsset_LicenseLicenseID,
                        principalTable: "License",
                        principalColumn: "LicenseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Relationship",
                columns: table => new
                {
                    RelationshipID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Relationship_AssetIDmomAssetID = table.Column<int>(nullable: true),
                    Relationship_AssetIDsonAssetID = table.Column<int>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationship", x => x.RelationshipID);
                    table.ForeignKey(
                        name: "FK_Relationship_Asset_Relationship_AssetIDmomAssetID",
                        column: x => x.Relationship_AssetIDmomAssetID,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relationship_Asset_Relationship_AssetIDsonAssetID",
                        column: x => x.Relationship_AssetIDsonAssetID,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    ReportID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Report_EmployeeIDEmployeeID = table.Column<int>(nullable: true),
                    Report_AssetIDAssetID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.ReportID);
                    table.ForeignKey(
                        name: "FK_Report_Asset_Report_AssetIDAssetID",
                        column: x => x.Report_AssetIDAssetID,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Report_Employee_Report_EmployeeIDEmployeeID",
                        column: x => x.Report_EmployeeIDEmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UpdateAsset",
                columns: table => new
                {
                    UpdateAssetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetName = table.Column<string>(nullable: true),
                    SerailNumber = table.Column<string>(nullable: true),
                    MACAddr = table.Column<string>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    PONumber = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    UpdateAsset_LocationIDLocationID = table.Column<int>(nullable: true),
                    UpdateAsset_CompanyIDCompanyID = table.Column<int>(nullable: true),
                    UpdateAsset_SepartmentIDDepartmentID = table.Column<int>(nullable: true),
                    UpdateAsset_SupplierIDSupplierID = table.Column<int>(nullable: true),
                    UpdateAsset_EmployeeIDEmployeeID = table.Column<int>(nullable: true),
                    UpdateAsset_AssetIDAssetID = table.Column<int>(nullable: true),
                    UpdateAsset_ModelIDModelID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdateAsset", x => x.UpdateAssetID);
                    table.ForeignKey(
                        name: "FK_UpdateAsset_Asset_UpdateAsset_AssetIDAssetID",
                        column: x => x.UpdateAsset_AssetIDAssetID,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateAsset_Company_UpdateAsset_CompanyIDCompanyID",
                        column: x => x.UpdateAsset_CompanyIDCompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateAsset_Employee_UpdateAsset_EmployeeIDEmployeeID",
                        column: x => x.UpdateAsset_EmployeeIDEmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateAsset_Location_UpdateAsset_LocationIDLocationID",
                        column: x => x.UpdateAsset_LocationIDLocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateAsset_Models_UpdateAsset_ModelIDModelID",
                        column: x => x.UpdateAsset_ModelIDModelID,
                        principalTable: "Models",
                        principalColumn: "ModelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateAsset_Department_UpdateAsset_SepartmentIDDepartmentID",
                        column: x => x.UpdateAsset_SepartmentIDDepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UpdateAsset_Supplier_UpdateAsset_SupplierIDSupplierID",
                        column: x => x.UpdateAsset_SupplierIDSupplierID,
                        principalTable: "Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Competency",
                columns: table => new
                {
                    CompetencyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompDetaill = table.Column<string>(nullable: true),
                    CompSumPoint = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Competency_EmployeeIDEmployeeID = table.Column<int>(nullable: true),
                    Competency_GradeHistoryIDGradeHistoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competency", x => x.CompetencyID);
                    table.ForeignKey(
                        name: "FK_Competency_Employee_Competency_EmployeeIDEmployeeID",
                        column: x => x.Competency_EmployeeIDEmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Competency_GradeHistory_Competency_GradeHistoryIDGradeHistoryID",
                        column: x => x.Competency_GradeHistoryIDGradeHistoryID,
                        principalTable: "GradeHistory",
                        principalColumn: "GradeHistoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KPI",
                columns: table => new
                {
                    KPIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KPIDetail = table.Column<string>(nullable: true),
                    KPISumPoint = table.Column<int>(nullable: false),
                    KPI_EmployeeIDEmployeeID = table.Column<int>(nullable: true),
                    KPI_GradeHistoryIDGradeHistoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KPI", x => x.KPIID);
                    table.ForeignKey(
                        name: "FK_KPI_Employee_KPI_EmployeeIDEmployeeID",
                        column: x => x.KPI_EmployeeIDEmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KPI_GradeHistory_KPI_GradeHistoryIDGradeHistoryID",
                        column: x => x.KPI_GradeHistoryIDGradeHistoryID,
                        principalTable: "GradeHistory",
                        principalColumn: "GradeHistoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suggestion",
                columns: table => new
                {
                    SuggestionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SugDetail = table.Column<string>(nullable: true),
                    SugSumPoint = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Suggestion_EmployeeIDEmployeeID = table.Column<int>(nullable: true),
                    Suggestion_GradeHistoryIDGradeHistoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggestion", x => x.SuggestionID);
                    table.ForeignKey(
                        name: "FK_Suggestion_Employee_Suggestion_EmployeeIDEmployeeID",
                        column: x => x.Suggestion_EmployeeIDEmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suggestion_GradeHistory_Suggestion_GradeHistoryIDGradeHistoryID",
                        column: x => x.Suggestion_GradeHistoryIDGradeHistoryID,
                        principalTable: "GradeHistory",
                        principalColumn: "GradeHistoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JoinAssetEmp_Cock",
                columns: table => new
                {
                    JoinAssetEmp_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(nullable: true),
                    Strint = table.Column<string>(nullable: true),
                    EmployeeIDEmployee_CockID = table.Column<int>(nullable: true),
                    AssetNameAsset_CockID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinAssetEmp_Cock", x => x.JoinAssetEmp_CockID);
                    table.ForeignKey(
                        name: "FK_JoinAssetEmp_Cock_Asset_Cock_AssetNameAsset_CockID",
                        column: x => x.AssetNameAsset_CockID,
                        principalTable: "Asset_Cock",
                        principalColumn: "Asset_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JoinAssetEmp_Cock_Employee_Cock_EmployeeIDEmployee_CockID",
                        column: x => x.EmployeeIDEmployee_CockID,
                        principalTable: "Employee_Cock",
                        principalColumn: "Employee_CockID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Report_Cock",
                columns: table => new
                {
                    Report_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    EmployeeIDEmployee_CockID = table.Column<int>(nullable: true),
                    AssetIDAsset_CockID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report_Cock", x => x.Report_CockID);
                    table.ForeignKey(
                        name: "FK_Report_Cock_Asset_Cock_AssetIDAsset_CockID",
                        column: x => x.AssetIDAsset_CockID,
                        principalTable: "Asset_Cock",
                        principalColumn: "Asset_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Report_Cock_Employee_Cock_EmployeeIDEmployee_CockID",
                        column: x => x.EmployeeIDEmployee_CockID,
                        principalTable: "Employee_Cock",
                        principalColumn: "Employee_CockID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Repair",
                columns: table => new
                {
                    RepairID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Repair_EmployeeIDEmployeeID = table.Column<int>(nullable: true),
                    Repair_ReportIDReportID = table.Column<int>(nullable: true),
                    Repair_AssetIDAssetID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repair", x => x.RepairID);
                    table.ForeignKey(
                        name: "FK_Repair_Asset_Repair_AssetIDAssetID",
                        column: x => x.Repair_AssetIDAssetID,
                        principalTable: "Asset",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Repair_Employee_Repair_EmployeeIDEmployeeID",
                        column: x => x.Repair_EmployeeIDEmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Repair_Report_Repair_ReportIDReportID",
                        column: x => x.Repair_ReportIDReportID,
                        principalTable: "Report",
                        principalColumn: "ReportID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Repair_Cock",
                columns: table => new
                {
                    Repair_CockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    EmployeeIDEmployee_CockID = table.Column<int>(nullable: true),
                    ReportIDReport_CockID = table.Column<int>(nullable: true),
                    AssetIDAsset_CockID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repair_Cock", x => x.Repair_CockID);
                    table.ForeignKey(
                        name: "FK_Repair_Cock_Asset_Cock_AssetIDAsset_CockID",
                        column: x => x.AssetIDAsset_CockID,
                        principalTable: "Asset_Cock",
                        principalColumn: "Asset_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Repair_Cock_Employee_Cock_EmployeeIDEmployee_CockID",
                        column: x => x.EmployeeIDEmployee_CockID,
                        principalTable: "Employee_Cock",
                        principalColumn: "Employee_CockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Repair_Cock_Report_Cock_ReportIDReport_CockID",
                        column: x => x.ReportIDReport_CockID,
                        principalTable: "Report_Cock",
                        principalColumn: "Report_CockID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Asset_CompanyIDCompanyID",
                table: "Asset",
                column: "Asset_CompanyIDCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Asset_DepartmentIDDepartmentID",
                table: "Asset",
                column: "Asset_DepartmentIDDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Asset_EmployeeIDEmployeeID",
                table: "Asset",
                column: "Asset_EmployeeIDEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Asset_LocationIDLocationID",
                table: "Asset",
                column: "Asset_LocationIDLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Asset_ModelIDModelID",
                table: "Asset",
                column: "Asset_ModelIDModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Asset_SupplierIDSupplierID",
                table: "Asset",
                column: "Asset_SupplierIDSupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Cock_CompanyIDCompany_CockID",
                table: "Asset_Cock",
                column: "CompanyIDCompany_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Cock_DepartmentIDDepartment_CockID",
                table: "Asset_Cock",
                column: "DepartmentIDDepartment_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Cock_EmployeeIDEmployee_CockID",
                table: "Asset_Cock",
                column: "EmployeeIDEmployee_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_Cock_SupplierIDSupplier_CockID",
                table: "Asset_Cock",
                column: "SupplierIDSupplier_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_AssetJoinNetworks_AssetJoinNetwork_AssetIDAssetID",
                table: "AssetJoinNetworks",
                column: "AssetJoinNetwork_AssetIDAssetID");

            migrationBuilder.CreateIndex(
                name: "IX_AssetJoinNetworks_AssetJoinNetwork_NetworkIDNetworkID",
                table: "AssetJoinNetworks",
                column: "AssetJoinNetwork_NetworkIDNetworkID");

            migrationBuilder.CreateIndex(
                name: "IX_CarQueue_CarQueue_CarTypeID",
                table: "CarQueue",
                column: "CarQueue_CarTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CarQueue_CarQueue_OTID",
                table: "CarQueue",
                column: "CarQueue_OTID");

            migrationBuilder.CreateIndex(
                name: "IX_CarQueue_CarQueue_PartID",
                table: "CarQueue",
                column: "CarQueue_PartID");

            migrationBuilder.CreateIndex(
                name: "IX_CarType_CompanyCarID",
                table: "CarType",
                column: "CompanyCarID");

            migrationBuilder.CreateIndex(
                name: "IX_Competency_Competency_EmployeeIDEmployeeID",
                table: "Competency",
                column: "Competency_EmployeeIDEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Competency_Competency_GradeHistoryIDGradeHistoryID",
                table: "Competency",
                column: "Competency_GradeHistoryIDGradeHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailCarQueue_DetailCarQueue_CarQueueID",
                table: "DetailCarQueue",
                column: "DetailCarQueue_CarQueueID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailCarQueue_DetailCarQueue_EmployeeID",
                table: "DetailCarQueue",
                column: "DetailCarQueue_EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_Employee_EmpID",
                table: "DetailOT",
                column: "Employee_EmpID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_FoodSet_FoodSetID",
                table: "DetailOT",
                column: "FoodSet_FoodSetID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_OT_OTID",
                table: "DetailOT",
                column: "OT_OTID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_Part_PaetID",
                table: "DetailOT",
                column: "Part_PaetID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_Cock_CarType_CockID",
                table: "DetailOT_Cock",
                column: "CarType_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_Cock_EmployeeIDEmployee_CockID",
                table: "DetailOT_Cock",
                column: "EmployeeIDEmployee_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_Cock_FoodSet_CockID",
                table: "DetailOT_Cock",
                column: "FoodSet_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_Cock_OTIDOT_CockID",
                table: "DetailOT_Cock",
                column: "OTIDOT_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOT_Cock_PartIDPart_CockID",
                table: "DetailOT_Cock",
                column: "PartIDPart_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Employee_CompanyID",
                table: "Employee",
                column: "Employee_CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Employee_DepartmentID",
                table: "Employee",
                column: "Employee_DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Employee_EmployeeTypeID",
                table: "Employee",
                column: "Employee_EmployeeTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Employee_LocationID",
                table: "Employee",
                column: "Employee_LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Employee_PositionID",
                table: "Employee",
                column: "Employee_PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Cock_CompanyIDCompany_CockID",
                table: "Employee_Cock",
                column: "CompanyIDCompany_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Cock_DepartmentNameDepartment_CockID",
                table: "Employee_Cock",
                column: "DepartmentNameDepartment_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Cock_EmployeeType_CockID",
                table: "Employee_Cock",
                column: "EmployeeType_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Cock_PositionIDPosition_CockID",
                table: "Employee_Cock",
                column: "PositionIDPosition_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodSet_Canteen_CanteenID",
                table: "FoodSet",
                column: "Canteen_CanteenID");

            migrationBuilder.CreateIndex(
                name: "IX_GradeHistory_GradeHistory_EmployeeIDEmployeeID",
                table: "GradeHistory",
                column: "GradeHistory_EmployeeIDEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_GradeHistory_Cock_EmployeeIDEmployee_CockID",
                table: "GradeHistory_Cock",
                column: "EmployeeIDEmployee_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_JoinAssetEmp_JoinAssetEmp_AssetIDAssetID",
                table: "JoinAssetEmp",
                column: "JoinAssetEmp_AssetIDAssetID");

            migrationBuilder.CreateIndex(
                name: "IX_JoinAssetEmp_JoinAssetEmp_EmployeeIDEmployeeID",
                table: "JoinAssetEmp",
                column: "JoinAssetEmp_EmployeeIDEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_JoinAssetEmp_Cock_AssetNameAsset_CockID",
                table: "JoinAssetEmp_Cock",
                column: "AssetNameAsset_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_JoinAssetEmp_Cock_EmployeeIDEmployee_CockID",
                table: "JoinAssetEmp_Cock",
                column: "EmployeeIDEmployee_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_JoinLicenseAsset_JoinLicenseAsset_AssetIDAssetID",
                table: "JoinLicenseAsset",
                column: "JoinLicenseAsset_AssetIDAssetID");

            migrationBuilder.CreateIndex(
                name: "IX_JoinLicenseAsset_JoinLicenseAsset_LicenseLicenseID",
                table: "JoinLicenseAsset",
                column: "JoinLicenseAsset_LicenseLicenseID");

            migrationBuilder.CreateIndex(
                name: "IX_KPI_KPI_EmployeeIDEmployeeID",
                table: "KPI",
                column: "KPI_EmployeeIDEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_KPI_KPI_GradeHistoryIDGradeHistoryID",
                table: "KPI",
                column: "KPI_GradeHistoryIDGradeHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_License_License_CompanyIDCompanyID",
                table: "License",
                column: "License_CompanyIDCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_License_License_DepartmentIDDepartmentID",
                table: "License",
                column: "License_DepartmentIDDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_License_License_ModelIDModelID",
                table: "License",
                column: "License_ModelIDModelID");

            migrationBuilder.CreateIndex(
                name: "IX_License_License_SupplierIDSupplierID",
                table: "License",
                column: "License_SupplierIDSupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Login_Login_EmployeeID",
                table: "Login",
                column: "Login_EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Models_Model_BrandIDBrandID",
                table: "Models",
                column: "Model_BrandIDBrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Models_Model_CategoryIDCategoryID",
                table: "Models",
                column: "Model_CategoryIDCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Point_Point_PartIDPartID",
                table: "Point",
                column: "Point_PartIDPartID");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship_Relationship_AssetIDmomAssetID",
                table: "Relationship",
                column: "Relationship_AssetIDmomAssetID");

            migrationBuilder.CreateIndex(
                name: "IX_Relationship_Relationship_AssetIDsonAssetID",
                table: "Relationship",
                column: "Relationship_AssetIDsonAssetID");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_Repair_AssetIDAssetID",
                table: "Repair",
                column: "Repair_AssetIDAssetID");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_Repair_EmployeeIDEmployeeID",
                table: "Repair",
                column: "Repair_EmployeeIDEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_Repair_ReportIDReportID",
                table: "Repair",
                column: "Repair_ReportIDReportID");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_Cock_AssetIDAsset_CockID",
                table: "Repair_Cock",
                column: "AssetIDAsset_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_Cock_EmployeeIDEmployee_CockID",
                table: "Repair_Cock",
                column: "EmployeeIDEmployee_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_Cock_ReportIDReport_CockID",
                table: "Repair_Cock",
                column: "ReportIDReport_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Report_Report_AssetIDAssetID",
                table: "Report",
                column: "Report_AssetIDAssetID");

            migrationBuilder.CreateIndex(
                name: "IX_Report_Report_EmployeeIDEmployeeID",
                table: "Report",
                column: "Report_EmployeeIDEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Report_Cock_AssetIDAsset_CockID",
                table: "Report_Cock",
                column: "AssetIDAsset_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Report_Cock_EmployeeIDEmployee_CockID",
                table: "Report_Cock",
                column: "EmployeeIDEmployee_CockID");

            migrationBuilder.CreateIndex(
                name: "IX_Suggestion_Suggestion_EmployeeIDEmployeeID",
                table: "Suggestion",
                column: "Suggestion_EmployeeIDEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Suggestion_Suggestion_GradeHistoryIDGradeHistoryID",
                table: "Suggestion",
                column: "Suggestion_GradeHistoryIDGradeHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateAsset_UpdateAsset_AssetIDAssetID",
                table: "UpdateAsset",
                column: "UpdateAsset_AssetIDAssetID");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateAsset_UpdateAsset_CompanyIDCompanyID",
                table: "UpdateAsset",
                column: "UpdateAsset_CompanyIDCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateAsset_UpdateAsset_EmployeeIDEmployeeID",
                table: "UpdateAsset",
                column: "UpdateAsset_EmployeeIDEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateAsset_UpdateAsset_LocationIDLocationID",
                table: "UpdateAsset",
                column: "UpdateAsset_LocationIDLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateAsset_UpdateAsset_ModelIDModelID",
                table: "UpdateAsset",
                column: "UpdateAsset_ModelIDModelID");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateAsset_UpdateAsset_SepartmentIDDepartmentID",
                table: "UpdateAsset",
                column: "UpdateAsset_SepartmentIDDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateAsset_UpdateAsset_SupplierIDSupplierID",
                table: "UpdateAsset",
                column: "UpdateAsset_SupplierIDSupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateLicense_UpdateLicense_CompanyIDCompanyID",
                table: "UpdateLicense",
                column: "UpdateLicense_CompanyIDCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateLicense_UpdateLicense_DepartmentIDDepartmentID",
                table: "UpdateLicense",
                column: "UpdateLicense_DepartmentIDDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateLicense_UpdateLicense_LicenseIDLicenseID",
                table: "UpdateLicense",
                column: "UpdateLicense_LicenseIDLicenseID");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateLicense_UpdateLicense_ModelIDModelID",
                table: "UpdateLicense",
                column: "UpdateLicense_ModelIDModelID");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateLicense_UpdateLicense_SupplierIDSupplierID",
                table: "UpdateLicense",
                column: "UpdateLicense_SupplierIDSupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateNetwork_UpdateNetwork_EmployeeIDEmployeeID",
                table: "UpdateNetwork",
                column: "UpdateNetwork_EmployeeIDEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateNetwork_UpdateNetwork_NetworkIDNetworkID",
                table: "UpdateNetwork",
                column: "UpdateNetwork_NetworkIDNetworkID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetJoinNetworks");

            migrationBuilder.DropTable(
                name: "Competency");

            migrationBuilder.DropTable(
                name: "DetailCarQueue");

            migrationBuilder.DropTable(
                name: "DetailOT");

            migrationBuilder.DropTable(
                name: "DetailOT_Cock");

            migrationBuilder.DropTable(
                name: "GradeHistory_Cock");

            migrationBuilder.DropTable(
                name: "JoinAssetEmp");

            migrationBuilder.DropTable(
                name: "JoinAssetEmp_Cock");

            migrationBuilder.DropTable(
                name: "JoinLicenseAsset");

            migrationBuilder.DropTable(
                name: "KPI");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Point");

            migrationBuilder.DropTable(
                name: "Relationship");

            migrationBuilder.DropTable(
                name: "Repair");

            migrationBuilder.DropTable(
                name: "Repair_Cock");

            migrationBuilder.DropTable(
                name: "Suggestion");

            migrationBuilder.DropTable(
                name: "UpdateAsset");

            migrationBuilder.DropTable(
                name: "UpdateLicense");

            migrationBuilder.DropTable(
                name: "UpdateNetwork");

            migrationBuilder.DropTable(
                name: "CarQueue");

            migrationBuilder.DropTable(
                name: "FoodSet");

            migrationBuilder.DropTable(
                name: "CarType_Cock");

            migrationBuilder.DropTable(
                name: "FoodSet_Cock");

            migrationBuilder.DropTable(
                name: "OT_Cock");

            migrationBuilder.DropTable(
                name: "Part_Cock");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "Report_Cock");

            migrationBuilder.DropTable(
                name: "GradeHistory");

            migrationBuilder.DropTable(
                name: "License");

            migrationBuilder.DropTable(
                name: "Network");

            migrationBuilder.DropTable(
                name: "CarType");

            migrationBuilder.DropTable(
                name: "OT");

            migrationBuilder.DropTable(
                name: "Part");

            migrationBuilder.DropTable(
                name: "Canteen");

            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "Asset_Cock");

            migrationBuilder.DropTable(
                name: "CompanyCar");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Employee_Cock");

            migrationBuilder.DropTable(
                name: "Supplier_Cock");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "EmployeeType");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Company_Cock");

            migrationBuilder.DropTable(
                name: "Department_Cock");

            migrationBuilder.DropTable(
                name: "EmployeeType_Cock");

            migrationBuilder.DropTable(
                name: "Position_Cock");
        }
    }
}
