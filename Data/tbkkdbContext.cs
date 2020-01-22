using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace tbkk.Models
{
    public class tbkkdbContext : DbContext
    {
        public tbkkdbContext (DbContextOptions<tbkkdbContext> options)
            : base(options)
        {
        }

        public DbSet<tbkk.Models.Asset> Asset { get; set; }
        public DbSet<tbkk.Models.AssetJoinNetwork> AssetJoinNetworks { get; set; }
        public DbSet<tbkk.Models.Brand> Brand { get; set; }
        public DbSet<tbkk.Models.Canteen> Canteen { get; set; }
        public DbSet<tbkk.Models.CarType> CarType { get; set; }
        public DbSet<tbkk.Models.Category> Category { get; set; }
        public DbSet<tbkk.Models.Company> Company { get; set; }
        public DbSet<tbkk.Models.CompanyCar> CompanyCar { get; set; }
        public DbSet<tbkk.Models.Competency> Competency { get; set; }
        public DbSet<tbkk.Models.Department> Department { get; set; }
        public DbSet<tbkk.Models.DetailOT> DetailOT { get; set; }
        public DbSet<tbkk.Models.Employee> Employee { get; set; }
        public DbSet<tbkk.Models.EmployeeType> EmployeeType { get; set; }
        public DbSet<tbkk.Models.FoodSet> FoodSet { get; set; }
        public DbSet<tbkk.Models.GradeHistory> GradeHistory { get; set; }
        public DbSet<tbkk.Models.JoinAssetEmp> JoinAssetEmp { get; set; }
        public DbSet<tbkk.Models.JoinLicenseAsset> JoinLicenseAsset { get; set; }
        public DbSet<tbkk.Models.KPI> KPI { get; set; }
        public DbSet<tbkk.Models.License> License { get; set; }
        public DbSet<tbkk.Models.Location> Location { get; set; }
        public DbSet<tbkk.Models.Login> Login { get; set; }
        
        public DbSet<tbkk.Models.Network> Network { get; set; }
        public DbSet<tbkk.Models.OT> OT { get; set; }
        public DbSet<tbkk.Models.Part> Part { get; set; }
        public DbSet<tbkk.Models.Point> Point { get; set; }
        public DbSet<tbkk.Models.Position> Position { get; set; }
        public DbSet<tbkk.Models.Relationship> Relationship { get; set; }
        public DbSet<tbkk.Models.Repair> Repair { get; set; }
        public DbSet<tbkk.Models.Report> Report { get; set; }
        public DbSet<tbkk.Models.Suggestion> Suggestion { get; set; }
        public DbSet<tbkk.Models.Supplier> Supplier { get; set; }
        public DbSet<tbkk.Models.UpdateAsset> UpdateAsset { get; set; }
        public DbSet<tbkk.Models.UpdateLicense> UpdateLicense { get; set; }
        public DbSet<tbkk.Models.UpdateNetwork> UpdateNetwork { get; set; }
        public DbSet<tbkk.Models.Asset_Cock> Asset_Cock { get; set; }
        public DbSet<tbkk.Models.CarType_Cock> CarType_Cock { get; set; }
        public DbSet<tbkk.Models.Company_Cock> Company_Cock { get; set; }
        public DbSet<tbkk.Models.Department_Cock> Department_Cock { get; set; }
        public DbSet<tbkk.Models.DetailOT_Cock> DetailOT_Cock { get; set; }
        public DbSet<tbkk.Models.EmployeeType_Cock> EmployeeType_Cock { get; set; }
        public DbSet<tbkk.Models.Employee_Cock> Employee_Cock { get; set; }
        public DbSet<tbkk.Models.FoodSet_Cock> FoodSet_Cock { get; set; }
        public DbSet<tbkk.Models.GradeHistory_Cock> GradeHistory_Cock { get; set; }
        public DbSet<tbkk.Models.JoinAssetEmp_Cock> JoinAssetEmp_Cock { get; set; }
        public DbSet<tbkk.Models.OT_Cock> OT_Cock { get; set; }
        public DbSet<tbkk.Models.Part_Cock> Part_Cock { get; set; }
        public DbSet<tbkk.Models.Position_Cock> Position_Cock { get; set; }
        public DbSet<tbkk.Models.Repair_Cock> Repair_Cock { get; set; }
        public DbSet<tbkk.Models.Report_Cock> Report_Cock { get; set; }
        public DbSet<tbkk.Models.Supplier_Cock> Supplier_Cock { get; set; }
        public DbSet<tbkk.Models.CarQueue> CarQueue { get; set; }
        public DbSet<tbkk.Models.DetailCarQueue> DetailCarQueue { get; set; }
        public DbSet<tbkk.Models.Model> Models { get; set; }
    }
}
