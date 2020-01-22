using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkk.Models;

namespace tbkk
{
    public class ContactCarFoodModel : PageModel
    {
        private readonly tbkk.Models.tbkkdbContext _context;

        public ContactCarFoodModel(tbkk.Models.tbkkdbContext context)
        {
            _context = context;
        }
        public IList<DetailOT> DetailOTnew { get; set; }
        public IList<FoodSet> FoodSet { get; set; }
        public IList<Part> Part { get; set; }
        public IList<CarType> CarType { get; set; }
        public IList<DetailOT> DetailOT { get; set; }
        public IList<Department> Department { get; set; }
        public Employee Employee { get; set; }
        public IList<Depasments> Depasments { get; set; }
        public IList<CarQueue> CarQueue { get; set; }
        public IList<DetailCarQueue> DetailCarQueue { get; set; }
        public OTs OTs { get; set; }
        public OT OT { get; set; }

        public IList<food> food { get; set; }

        
        public IList<timelist> timelist { get; set; }

        

        public string foodToken = "gpLcFbnpq8RcdSP67A4vFdZMKlfz9vBDlI0IVB2TsXV";
        public string carToken = "YGWdtLg5mavVWPlBmU0CT2WcZspAguWgZljx7FXBIEk";

        public async Task OnPostLineAsync(int id, int Did)
        {
            Line l = new Line();

            string massCar = Request.Form["massCar"];
            string massFood = Request.Form["massFood"];
            await onLoad(id, Did);
            //food
            l.lineNotify(massFood, foodToken);
            //l.notifySticker("5564", 150, 2, foodToken);
            //car
            l.lineNotify(massCar, carToken);
            //l.notifySticker("5564", 160, 2, carToken);

            
            //FromDataManage(Did);
        }



        //public IList<CatList> CatList { get; set; }
        
        public async Task<IActionResult> OnGetAsync(int? id ,int? Did)
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
            return Page();
        }

        private List<food> foodMass()
        {
            var foodAdd = new List<food>();

            for (int i = 0; i < 2; i++)
            {
                var Addfood = new food();

                int timeCheck = 0;
                if (i == 0)
                {
                    timeCheck = 8;
                }
                else
                {
                    timeCheck = 17;
                }
                var foodlist = new List<foodList>();
                foreach (var item in FoodSet)
                {
                    if (!item.NameSet.Equals("No"))
                    {
                        var add = new foodList();
                        if (timeCheck == 8)
                        {
                            add.list = DetailOTnew.Where(c => c.TimeStart.Hour == timeCheck && c.TimeStart.Minute == 0 && c.FoodSet_FoodSetID == item.FoodSetID).ToList();
                            add.set = item;
                            add.contSet = DetailOTnew.Where(c => c.TimeStart.Hour == timeCheck && c.TimeStart.Minute == 0 && c.FoodSet_FoodSetID == item.FoodSetID).ToList().Count;
                        }
                        if (timeCheck == 17)
                        {
                            add.list = DetailOTnew.Where(c => c.TimeEnd.Hour == timeCheck && c.TimeEnd.Minute == 0 && c.FoodSet_FoodSetID == item.FoodSetID).ToList();
                            add.set = item;
                            add.contSet = DetailOTnew.Where(c => c.TimeEnd.Hour == timeCheck && c.TimeEnd.Minute == 0 && c.FoodSet_FoodSetID == item.FoodSetID).ToList().Count;
                        }
                        if (add.contSet != 0)
                        {
                            foodlist.Add(add);
                        }
                    }
                }
                Addfood.time = timeCheck;
                Addfood.foodList = foodlist;

                if (Addfood.foodList.Count != 0)
                {
                    foodAdd.Add(Addfood);
                }

            }

            return foodAdd;
        }

        private List<timelist> massCarQ()
        {
            List<timelist> add = new List<timelist>();
            for (int a = 0; a < 3; a++)
            {
                int time;
                if (a == 0)
                {
                    time = 8;
                }
                else if (a == 1)
                {
                    time = 17;
                }
                else
                {
                    time = 20;
                }
                var listAdd = new timelist();
                listAdd.time = time;
                var addcarq = new List<carQ>();
                foreach (var item in Part)
                {

                    if (!item.Name.Equals("No"))
                    {
                        var list = CarQueue.Where(l => l.CarQueue_PartID == item.PartID && l.Time.Hour == time).ToList();

                        if (list.Count != 0)
                        {
                            carQ AddCarQ = new carQ();
                            AddCarQ.part = item;

                            var addList = new List<carListNumber>();
                            foreach (var i in CarType)
                            {
                                var CarTypePart = list.Where(c => c.CarQueue_CarTypeID == i.CarTypeID).ToList();
                                if (CarTypePart.Count != 0 && i.Seat != 0)
                                {
                                    carListNumber carListNumber = new carListNumber();


                                    carListNumber.CarType = i;
                                    carListNumber.maxCar = CarTypePart.Max(z => z.CarNumber);
                                    addList.Add(carListNumber);

                                }
                            }

                            AddCarQ.carListNumber = addList;
                            addcarq.Add(AddCarQ);


                        }

                    }


                }
                listAdd.carQ = addcarq;
                if (listAdd.carQ.Count != 0)
                {
                     add.Add(listAdd);
                }
               
            }

            return add;
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
            Part = await _context.Part.ToListAsync();
            FoodSet = await _context.FoodSet.ToListAsync();
            CarType = await _context.CarType.ToListAsync();
            CarType = CarType.OrderByDescending(o => o.Seat).ToList();
            DetailCarQueue = await _context.DetailCarQueue
              .Include(e => e.CarQueue)
              .Include(e => e.Employee)
              .Where(c => c.CarQueue.CarQueue_OTID == Did).ToListAsync();
            CarQueue = await _context.CarQueue
                .Include(e => e.OT)
                .Include(e => e.Part)
                .Include(e => e.CarType)
                .Where(c => c.CarQueue_OTID == Did).ToListAsync();
            OTs = ListOTDetail(Did);
            Depasments = OTDetailOTList();
            timelist = massCarQ();
            food = foodMass();


            
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
                    IList<DetailOT> DataPart = DetailOTnew.Where(d => d.FoodSet.NameSet.Equals("No")).ToList();
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

        private OTs ListOTDetail(int? Did)
        {
            OTs OTsnew = new OTs();


            DetailOTnew = DetailOT.Where(d => d.OT_OTID == Did && d.Status.Equals("Allow")).ToList();
            OTsnew.countEmp = DetailOTnew.Count;

            foreach (var i in DetailOTnew)
            {
                if (i.FoodSet.NameSet.Equals("No"))
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
    }


  

    public class carListNumber
    {
        public CarType CarType { get; set; }
        public int maxCar { get; set; }
    }


    public class carQ
    {
        public Part part { get; set; }
        public IList<carListNumber> carListNumber { get; set; }
       
    }

    public class timelist
    {
        public int time { get; set; }
        public IList<carQ> carQ { get; set; }
    }

    public class foodList
    {
        public IList<DetailOT>  list { get; set; }
        public FoodSet set { get; set; }
        public int contSet { get; set; }
    }



    public class food
    {
        public int time { get; set; }
        public IList<foodList> foodList { get; set; }
    }

}
