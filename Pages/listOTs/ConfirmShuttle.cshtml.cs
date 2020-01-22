using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk.Models;
using Newtonsoft.Json;
using System.Diagnostics;

namespace tbkk.Pages.listOTs
{
    public class ConfirmShuttleModel : PageModel
    {
        private readonly tbkk.Models.tbkkdbContext _context;

        public ConfirmShuttleModel(tbkk.Models.tbkkdbContext context)
        {
            _context = context;
        }

        public IList<DetailOT> DetailOT { get;set; }

        
        public OT OT { get; set; }
        
        public Employee Employee { get; set; }



       


        




       
        


        [BindProperty]
        public IList<CarsPart> Round_8 { get; set; }
        [BindProperty]
        public IList<CarsPart> Round_17 { get; set; }
        [BindProperty]
        public IList<CarsPart> Round_20 { get; set; }



        public IList<FoodSet> FoodSet { get; set; }
        public IList<Part> Part { get; set; }
        public IList<DetailOT> DetailOTnew { get; set; }
        public IList<Department> Department { get; set; }
        public IList<CarType> CarType { get; set; }
        public OTs OTs { get; set; }
        public IList<Depasments> Depasments { get; set; }
        public IList<Cars> Cars { get; set; }
        

        public async Task<IActionResult> OnGetAsync(int? id, int? Did)
        {

            if (id == null)
            {
                return NotFound();
            }
            await onLoad(id, Did);
            if (OT == null)
            {
                return NotFound();
            }
            if (Employee == null)
            {
                return NotFound();
            }
                    
            OTs = ListOTDetail(Did);


            
            Depasments = OTDetailOTList();


            IList<DetailOT> mDetailOTnew;
            if (OT.TypeOT.Equals("Saturday") || OT.TypeOT.Equals("Sunday"))
            {
                mDetailOTnew = DetailOT.Where(d => (d.Type.Equals("Go") || d.Type.Equals("Go and Back"))&& d.TimeStart.Hour==8 && d.TimeStart.Minute == 0).ToList();
                Round_8 = ManageCar(mDetailOTnew);
                mDetailOTnew = DetailOT.Where(d => (d.Type.Equals("Back") || d.Type.Equals("Go and Back")) && d.TimeEnd.Hour == 17 && d.TimeEnd.Minute == 0).ToList();
                Round_17 = ManageCar(mDetailOTnew);
                mDetailOTnew = DetailOT.Where(d => (d.Type.Equals("Back") || d.Type.Equals("Go and Back")) && d.TimeEnd.Hour == 20 && d.TimeEnd.Minute == 0).ToList();
                Round_20 = ManageCar(mDetailOTnew);
            }
            else
            {
                mDetailOTnew = DetailOT.Where(d => d.Type.Equals("Back") && d.TimeEnd.Hour == 20 && d.TimeEnd.Minute == 0).ToList();
                Round_20 = ManageCar(mDetailOTnew);
            }
            return Page();
        }



        private OTs ListOTDetail(int? Did)
        {
            OTs OTsnew = new OTs();
            
           
            DetailOTnew = DetailOT;
            OTsnew.countEmp = DetailOTnew.Count;

            foreach (var i in DetailOTnew)
            {
                if (i.FoodSet_FoodSetID != 1)
                {
                    OTsnew.countFood = OTsnew.countFood + 1;
                }
                if (!i.Type.Equals("No"))
                {
                    OTsnew.countCar = OTsnew.countCar + 1;
                }

            }

            return OTsnew;
        }




        private List<Depasments> OTDetailOTList()
        {
            List<Depasments> add = new List<Depasments>();
            foreach (var i in Department)
            {
                Depasments DataDepasments = new Depasments();
                DataDepasments.DepasmentsName = i.DepartmentName;
                DataDepasments.DepasmentsID = i.DepartmentID;
                DataDepasments.DepasmentsCount = DetailOTnew.Where(d => d.Employee.Employee_DepartmentID == i.DepartmentID).ToList().Count;
                DataDepasments.CarCount = DetailOTnew.Where(d => !d.Type.Equals("No") && d.Employee.Employee_DepartmentID == i.DepartmentID).ToList().Count;
                DataDepasments.FoodCount = DetailOTnew.Where(d => d.FoodSet_FoodSetID != 1 && d.Employee.Employee_DepartmentID == i.DepartmentID).ToList().Count;
                List<Parts> Listparts = new List<Parts>();
                foreach (var j in Part)
                {
                    Parts parts = new Parts();
                    parts.PartID = j.PartID;
                    parts.PartName = j.Name;
                    IList<DetailOT> DataPart = DetailOTnew.Where(d => d.Part_PaetID != 1).ToList();
                    DataPart = DataPart.Where(d => d.Employee.Employee_DepartmentID == i.DepartmentID).ToList();
                    DataPart = DataPart.Where(d => d.Part_PaetID == j.PartID).ToList();
                    parts.PartsCount = DataPart.Where(d => !d.Type.Equals("No")).ToList().Count;
                    if (parts.PartsCount != 0)
                    {
                        Listparts.Add(parts);
                       
                    }

                }
                DataDepasments.ListParts = Listparts;
                List<Foods> Listfoods = new List<Foods>();

                foreach (var j in FoodSet)
                {
                    Foods foods = new Foods();
                    foods.FoodID = j.FoodSetID;
                    foods.FoodName = j.NameSet;
                    IList<DetailOT> DataPart = DetailOTnew.Where(d => d.FoodSet_FoodSetID != 1).ToList();
                    DataPart = DataPart.Where(d => d.Employee.Employee_DepartmentID == i.DepartmentID).ToList();
                    DataPart = DataPart.Where(d => d.FoodSet_FoodSetID == j.FoodSetID).ToList();
                    foods.FoodsCount = DataPart.Where(d => !d.Type.Equals("No")).ToList().Count;
                    if (foods.FoodsCount != 0)
                    {
                        Listfoods.Add(foods);
                       
                    }

                }
                DataDepasments.ListFoods = Listfoods;
                add.Add(DataDepasments);
            }

            return add;
        }

        private List<CarsPart> ManageCar(IList<DetailOT> mDetailOTnew)
        {
            List<CarsPart> CarsParts = new List<CarsPart>();
            foreach (var i in Part)
            {
                CarsPart CarsPartNew = new CarsPart();
                CarsPartNew.PartID = i.PartID;
                CarsPartNew.namePart = i.Name;
                
                List<Cars> CarsNew = new List<Cars>();
               
                CarsPartNew.DetailOT = mDetailOTnew.Where(c => c.Part_PaetID == i.PartID).ToList();
                int count = mDetailOTnew.Where(c => c.Part_PaetID == i.PartID).ToList().Count;
                
                foreach (var j in CarType)
                {
                    if (j.Seat != 0)
                    {
                        Cars cars = new Cars();
                        if (j.Seat <= count)
                        {
                        
                            cars.CarTypeID = j.CarTypeID;
                            cars.CarTypeName = j.NameCar;
                            cars.seed = j.Seat;



                        
                            int add = count / j.Seat;
                            count = count % j.Seat;
                            cars.countCar = add;
                            CarsNew.Add(cars);
                        
                    }
                        else
                        {
                        
                            cars.CarTypeID = j.CarTypeID;
                            cars.CarTypeName = j.NameCar;
                            cars.seed = j.Seat;
                            cars.countCar = 0;
                            CarsNew.Add(cars);
                        }
                    }
                    
                }
                Cars min = new Cars();
                int seedMon = 9999;
                foreach (var j in CarType)
                {
                    if (j.Seat != 0)
                    {
                        if (j.Seat < seedMon)
                        {
                            seedMon = j.Seat;
                            min.CarTypeID = j.CarTypeID;
                            min.CarTypeName = j.NameCar;
                            min.seed = j.Seat;
                            min.countCar = 1;
                            
                        }
                    }
                }

                if (count > 0)
                {
                    int check = 0;
                    foreach (var j in CarsNew)
                    {
                        if (j.CarTypeID == min.CarTypeID)
                        {
                            check = +1;
                            j.countCar = j.countCar + 1;
                            break;
                        }
                    }
                    if (check == 0)
                    {
                        CarsNew.Add(min);
                    }

                }


                CarsPartNew.ListCars = CarsNew;
                if (DetailOTnew.Where(d => d.Part_PaetID == i.PartID).ToList().Count != 0)
                {
                    CarsParts.Add(CarsPartNew);
                }
            }

            return CarsParts;
        }

        private async Task onLoad(int? id, int? Did)
        {
            Department = await _context.Department.ToListAsync();
            Employee = await _context.Employee
             .Include(e => e.Company)
             .Include(e => e.Department)
             .Include(e => e.EmployeeType)
             .Include(e => e.Location)
             .Include(e => e.Position).FirstOrDefaultAsync(m => m.EmployeeID == id);
            OT = await _context.OT.FirstOrDefaultAsync(m => m.OTID == Did);
            DetailOT = await _context.DetailOT
                .Include(d => d.Employee)
                .Include(d => d.FoodSet)
                .Include(d => d.OT)
                .Include(d => d.Part).ToListAsync();
            DetailOT = DetailOT.Where(d =>d.OT_OTID==Did && d.Status.Equals("Allow")).ToList();
            Part = await _context.Part.ToListAsync();
            FoodSet =await _context.FoodSet.ToListAsync();
            CarType = await _context.CarType.ToListAsync();

            



            CarType = CarType.OrderByDescending(o => o.Seat).ToList();
            






        }


        public async Task<ActionResult> OnPostAsync(int id,int Did)
        {
            OT = await _context.OT.FirstOrDefaultAsync(m => m.OTID == Did);

           

            if (Round_8.Any())
            {
                int time = 8;
                string type = "Go";
                IList<CarsPart> managecarNEW = Round_8;

                await createDetailCarQ(Did, time, type, managecarNEW);

            }
            else
            {
                Debug.WriteLine("Round_8 Null");
            }


            if (Round_17.Any())
            {
                int time = 17;
                string type = "Back";
                IList<CarsPart> managecarNEW = Round_17;

                await createDetailCarQ(Did, time, type, managecarNEW);

            }
            else
            {
                Debug.WriteLine("Round_17 Null");
            }

            if (Round_20.Any())
            {
                int time = 20;
                string type = "Back";
                IList<CarsPart> managecarNEW = Round_20;

                await createDetailCarQ(Did, time, type, managecarNEW);

            }
            else
            {
                Debug.WriteLine("Round_20 Null");
            }


            //_context.CarsPart.Add(Round_8);


            //Your logic here using Products and statusId 

            OT.TypStatus = "Close";
            _context.Attach(OT).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OTExists(OT.OTID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            
            return RedirectToPage("./../listOTs/ContactCarFood", new { id = id, Did = Did });

           
        }


        private bool OTExists(int id)
        {
            return _context.OT.Any(e => e.OTID == id);
        }

        private async Task createDetailCarQ(int Did, int time, string type, IList<CarsPart> managecarNEW)
        {
            foreach (var item in managecarNEW)
            {
                int index = managecarNEW.IndexOf(item);
                List<DetailOT> empList;

                try
                {
                    empList = item.DetailOT.Where(e => e.Part_PaetID == item.PartID).ToList();
                }
                catch (Exception e)
                {
                    empList = new List<DetailOT>();
                }
              

                foreach (var j in item.ListCars)
                {
                    int Emp = 0;
                    int index2 = managecarNEW[index].ListCars.IndexOf(j);
                    for (int i = 0; i < managecarNEW[index].ListCars[index2].countCar; i++)
                    {
                        
                        CarQueue createCarQueue = new CarQueue();
                        createCarQueue.CarNumber = i+1;
                        createCarQueue.Type = type;
                        createCarQueue.CarQueue_OTID = Did;
                        createCarQueue.Time = new DateTime(OT.date.Year, OT.date.Month, OT.date.Day, time, 0, 0);
                        createCarQueue.CarQueue_PartID = item.PartID;
                        createCarQueue.CarQueue_CarTypeID = j.CarTypeID;
                        _context.CarQueue.Add(createCarQueue);
                        await _context.SaveChangesAsync();

                       

                        for (int q = 1; q <= j.seed; q++)
                        {
                            if (Emp == empList.Count)
                            {
                                break;
                            }
                            DetailCarQueue createDetailCarQueue = new DetailCarQueue();
                            createDetailCarQueue.DetailCarQueue_EmployeeID = empList[Emp].Employee_EmpID;
                            createDetailCarQueue.DetailCarQueue_CarQueueID = createCarQueue.CarQueueID;
                            _context.DetailCarQueue.Add(createDetailCarQueue);
                            Emp = Emp + 1; 
                            await _context.SaveChangesAsync();
                        }


                       
                    }
                }
            }
        }
    }

}
