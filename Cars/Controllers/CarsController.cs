using Cars.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private AutomobileDbContext _dbcontext;
        public CarsController(AutomobileDbContext dbcontext) {
            _dbcontext = dbcontext;}
        [HttpGet("GetCar")]
        public IActionResult GetCar()
        {
            var car = _dbcontext.Car.ToList();

            return Ok(car);
        }
        [HttpPost("PostCar")]
        public IActionResult postCar( Car request)
        {
            Car car = new Car();
            car.car_id = request.car_id;
            car.manufacture_company = request.manufacture_company;
            car.manufacture_date = request.manufacture_date;
            car.model = request.model;
            car.engine_id = request.engine_id;
            car.plate_number = request.plate_number;
            car.gear_id = request.gear_id;
            car.body_serial_number = request.body_serial_number;
            car.length = request.length;
            car.width = request.width;
            car.color_id = request.color_id;
            car.seats = request.seats;
            car.is_leather = request.is_leather;
            car.is_deleted = request.is_deleted;
            car.deleted_at = request.deleted_at;
            car.TRIAL421 = request.TRIAL421;
            _dbcontext.Car.Add(car);
            _dbcontext.SaveChanges();


            

            return Ok();
        }
        [HttpPut("UpdateCar")]
        public IActionResult updateCar( Car request)
        {
            var car = _dbcontext.Car.FirstOrDefault(x => x.car_id == request.car_id);
            car.car_id = request.car_id;
            car.manufacture_company = request.manufacture_company;
            car.manufacture_date = request.manufacture_date;
            car.model = request.model;
            car.engine_id = request.engine_id;
            car.plate_number = request.plate_number;
            car.gear_id = request.gear_id;
            car.body_serial_number = request.body_serial_number;
            car.length = request.length;
            car.width = request.width;
            car.color_id = request.color_id;
            car.seats = request.seats;
            car.is_leather = request.is_leather;
            car.is_deleted = request.is_deleted;
            car.deleted_at = request.deleted_at;
            car.TRIAL421 = request.TRIAL421;
            _dbcontext.Entry(car).State = EntityState.Modified;
            _dbcontext.SaveChanges();
            return Ok(car);
        }
        [HttpDelete("DeleteCar/{id}")]
        public IActionResult DeleteCar( int id)
        {
            var car = _dbcontext.Car.FirstOrDefault(x => x.car_id == id);
            _dbcontext.Entry(car).State = EntityState.Deleted;
            _dbcontext.SaveChanges();
            return Ok(car);

        }

        [HttpGet("GetColor")]
        public IActionResult GetColor()
        {
            var color = _dbcontext.Color.ToList();

            return Ok(color);
        }
       [HttpPost("PostColor")]
       public IActionResult PostColor( Color request)
        {
            Color color = new Color();
            color.color_id = request.color_id;
            color.color_name = request.color_name;
            color.TRIAL424 = request.TRIAL424;
            _dbcontext.Color.Add(color);
            _dbcontext.SaveChanges();
            

            var colors = _dbcontext.Color.ToList();

            return Ok(color);
        }
        [HttpPut("UpdateColor")]
        public IActionResult UpdateColor(Color request)
        {
            var color = _dbcontext.Color.FirstOrDefault(x => x.color_id == request.color_id);
            color.color_id = request.color_id;
            color.color_name = request.color_name;
            color.TRIAL424 = request.TRIAL424;
            _dbcontext.Entry(color).State = EntityState.Modified;
            _dbcontext.SaveChanges();
            return Ok(color);
        }
        [HttpDelete("DeleteColor/{id}")]
        public IActionResult DeleteColor(int id) {
            var color = _dbcontext.Color.FirstOrDefault(x => x.color_id == id);
            _dbcontext.Entry(color).State = EntityState.Deleted;
            _dbcontext.SaveChanges();
            return Ok(color);

        }
        [HttpGet("GetEngine")]
        public IActionResult GetEngine()
        {
            var engine = _dbcontext.Engine.ToList();

            return Ok(engine);
        }
        [HttpPost("PostEngine")]
        public IActionResult PostEngine( Engine request)
        {
            Engine engine = new Engine();
            engine.engine_id = request.engine_id;
            engine.manufacture_company = request.manufacture_company;
            engine.manufacture_date = request.manufacture_date;
            engine.model = request.model;
            engine.fuel_id = request.fuel_id;
            engine.capacity = request.capacity;
            engine.cylinders = request.cylinders;
            engine.is_deleted = request.is_deleted;
            engine.deleted_at = request.deleted_at;
            engine.TRIAL424 = request.TRIAL424;
            _dbcontext.Engine.Add(engine);
            _dbcontext.SaveChanges();

            return Ok(); }


            
       
        [HttpPut("UpdateEngine")]
        public IActionResult UpdateEngine( Engine request)
        {
            var engine = _dbcontext.Engine.FirstOrDefault(x => x.engine_id == request.engine_id);
            engine.engine_id = request.engine_id;
            engine.manufacture_company = request.manufacture_company;
            engine.manufacture_date = request.manufacture_date;
            engine.model = request.model;
            engine.fuel_id = request.fuel_id;
            engine.capacity = request.capacity;
            engine.cylinders = request.cylinders;
            engine.is_deleted = request.is_deleted;
            engine.deleted_at = request.deleted_at;
            engine.TRIAL424 = request.TRIAL424;
            _dbcontext.Entry(engine).State = EntityState.Modified;
            _dbcontext.SaveChanges();
            return Ok(engine);
        }
        [HttpDelete("DeleteEngine/{id}")]
        public IActionResult DeleteEngine( int id)
        {
            var engine = _dbcontext.Engine.FirstOrDefault(x => x.engine_id == id);
            _dbcontext.Entry(engine).State = EntityState.Deleted;
            _dbcontext.SaveChanges();
            return Ok(engine);

        }
        [HttpGet("GetFuel")]
        public IActionResult GetFuel()
        {
            var fuel = _dbcontext.Fuel.ToList();

            return Ok(fuel);
        }
        [HttpPost("PostFuel")]
        public IActionResult PostFuel( Fuel request)
        {
            Fuel fuel = new Fuel();
            fuel.fuel_id = request.fuel_id;
            fuel.fuel_type= request.fuel_type;
            fuel.TRIAL424 = request.TRIAL424;
            _dbcontext.Fuel.Add(fuel);
            _dbcontext.SaveChanges();


            var colors = _dbcontext.Color.ToList();

            return Ok(fuel);
        }
        [HttpPut("UpdateFuel")]
        public IActionResult UpdateFuel(Fuel request)
        {
            var fuel = _dbcontext.Fuel.FirstOrDefault(x => x.fuel_id == request.fuel_id);
            fuel.fuel_id = request.fuel_id;
            fuel.fuel_type = request.fuel_type;
            fuel.TRIAL424 = request.TRIAL424;
            _dbcontext.Entry(fuel).State = EntityState.Modified;
            _dbcontext.SaveChanges();
            return Ok(fuel);
        }
        [HttpDelete("DeleteFuel/{id}")]
        public IActionResult DeleteFuel( int id)
        {
            var fuel = _dbcontext.Fuel.FirstOrDefault(x => x.fuel_id == id);
            _dbcontext.Entry(fuel).State = EntityState.Deleted;
            _dbcontext.SaveChanges();
            return Ok(fuel);

        }
        [HttpGet("GetGear")]
        public IActionResult GetGear()
        {
            var gear= _dbcontext.Gear.ToList();

            return Ok(gear);
        }
        [HttpPost("PostGear")]
        public IActionResult PostGear(Gear request)
        {
            Gear gear = new Gear();
            gear.gear_id = request.gear_id;
            gear.gear_type = request.gear_type;
            gear.TRIAL424 = request.TRIAL424;
            _dbcontext.Gear.Add(gear);
            _dbcontext.SaveChanges();


            var gears = _dbcontext.Gear.ToList();

            return Ok(gear);
        }
        [HttpPut("UpdateGear")]
        public IActionResult UpdateGear( Gear request)
        {
            var gear = _dbcontext.Gear.FirstOrDefault(x => x.gear_id == request.gear_id);
            gear.gear_id = request.gear_id;
            gear.gear_type = request.gear_type;
            gear.TRIAL424 = request.TRIAL424;
            _dbcontext.Entry(gear).State = EntityState.Modified;
            _dbcontext.SaveChanges();
            return Ok(gear);
        }
        [HttpDelete("DeleteGear/{id}")]
        public IActionResult DeleteGear( int id)
        {
            var gear = _dbcontext.Gear.FirstOrDefault(x => x.gear_id == id);
            _dbcontext.Entry(gear).State = EntityState.Deleted;
            _dbcontext.SaveChanges();
            return Ok(gear);

        }
        [HttpGet("GetSqlite")]
        public IActionResult GetSqlite()
        {
            var sqlite = _dbcontext.sqlite_sequence.ToList();

            return Ok(sqlite);
        }
        [HttpPost("PostSqlite")]
        public IActionResult PostSqlite( sqlite_sequence request)
        {
            sqlite_sequence sqlite = new sqlite_sequence();
            sqlite.name = request.name;
            sqlite.seq = request.seq;
            sqlite.TRIAL424 = request.TRIAL424;
            _dbcontext.sqlite_sequence.Add(sqlite);
            _dbcontext.SaveChanges();


            

            return Ok(sqlite);
        }
        [HttpPut("UpdateSqlite")]
        public IActionResult UpdateSqlite( sqlite_sequence request)
        {
            var sqlite = _dbcontext.sqlite_sequence.FirstOrDefault(x => x.name.Equals(request.name));
            sqlite.name = request.name;
            sqlite.seq = request.seq;
            sqlite.TRIAL424 = request.TRIAL424;
            _dbcontext.Entry(sqlite).State = EntityState.Modified;
            _dbcontext.SaveChanges();
            return Ok(sqlite);
        }
        [HttpDelete("DeleteSqlite/{name}")]
        public IActionResult DeleteSqlite( string name)
        {
            /* var sqlite = _dbcontext.sqlite_sequence.FirstOrDefault(x => x.name.Equals(name));
              _dbcontext.Entry(sqlite).State = EntityState.Deleted;
              _dbcontext.SaveChanges();
              return Ok(sqlite);*/
            sqlite_sequence sqlite = _dbcontext.sqlite_sequence.Where(s => s.name ==name).FirstOrDefault();
            _dbcontext.sqlite_sequence.Remove(sqlite);
            _dbcontext.SaveChanges();
            return Ok();

        }
        [HttpGet("GetTruck")]
        public IActionResult GetTruck()
        {
            var truck = _dbcontext.Truck.ToList();

            return Ok(truck);
        }
        [HttpPost("PostTruck")]
        public IActionResult PostTruck( Truck request)
        {
            Truck truck = new Truck();
            truck.truck_id = request.truck_id;
            truck.manufacture_company = request.manufacture_company;
            truck.manufacture_date = request.manufacture_date;
            truck.model = request.model;
            truck.engine_id = request.engine_id;
            truck.plate_number = request.plate_number;
            truck.gear_id = request.gear_id;
            truck.body_serial_number = request.body_serial_number;
            truck.length = request.length;
            truck.width = request.width;
            truck.color_id = request.color_id;
            truck.free_weight = request.free_weight;
            truck.full_weight = request.full_weight;
            truck.is_deleted = request.is_deleted;
            truck.deleted_at = request.deleted_at;
            truck.TRIAL424 = request.TRIAL424;
            _dbcontext.Truck.Add(truck);
            _dbcontext.SaveChanges();

            return Ok(truck);
        }
        [HttpPut("UpdateTruck")]
        public IActionResult UpdateTruck( Truck request)
        {
            var truck = _dbcontext.Truck.FirstOrDefault(x => x.truck_id == request.truck_id);
            truck.truck_id = request.truck_id;
            truck.manufacture_company = request.manufacture_company;
            truck.manufacture_date = request.manufacture_date;
            truck.model = request.model;
            truck.engine_id = request.engine_id;
            truck.plate_number = request.plate_number;
            truck.gear_id = request.gear_id;
            truck.body_serial_number = request.body_serial_number;
            truck.length = request.length;
            truck.width = request.width;
            truck.color_id = request.color_id;
            truck.free_weight = request.free_weight;
            truck.full_weight = request.full_weight;
            truck.is_deleted = request.is_deleted;
            truck.deleted_at = request.deleted_at;
            truck.TRIAL424 = request.TRIAL424;
            _dbcontext.Entry(truck).State = EntityState.Modified;
            _dbcontext.SaveChanges();
            return Ok(truck);
        }
        [HttpDelete("DeleteTruck/{id}")]
        public IActionResult DeleteTruck( int id )
        {
            var truck = _dbcontext.Truck.FirstOrDefault(x => x.truck_id == id);
            _dbcontext.Entry(truck).State = EntityState.Deleted;
            _dbcontext.SaveChanges();
            return Ok(truck);

        }
        [HttpGet("GetMotorcycle")]
        public IActionResult GetMotorcycle()
        {
            var motorcycle = _dbcontext.Motorcycle.ToList();

            return Ok(motorcycle);
        }
        [HttpPost("PostMotorcycle")]
        public IActionResult PostMotorcycle( Motorcycle request)
        {
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.motorcycle_id = request.motorcycle_id;
            motorcycle.manufacture_company = request.manufacture_company;
            motorcycle.manufcture_date = request.manufcture_date;
            motorcycle.model = request.model;
            motorcycle.engine_id = request.engine_id;
            motorcycle.plate_number = request.plate_number;
            motorcycle.gear_id = request.gear_id;
            motorcycle.body_serial_number = request.body_serial_number;
            
            motorcycle.tier_diameter = request.tier_diameter;

            motorcycle.length = request.length;
           
             motorcycle.is_deleted = request.is_deleted;
            motorcycle.deleted_at = request.deleted_at;
            motorcycle.TRIAL424 = request.TRIAL424;
            _dbcontext.Motorcycle.Add(motorcycle);
            _dbcontext.SaveChanges();

            return Ok(motorcycle);
        }
           



        [HttpPut("UpdateMotorcycle")]
        public IActionResult UpdateMotorcycle( Motorcycle request)
        {
            var motorcycle = _dbcontext.Motorcycle.FirstOrDefault(x => x.motorcycle_id== request.motorcycle_id);
            motorcycle.motorcycle_id = request.motorcycle_id;
            motorcycle.manufacture_company = request.manufacture_company;
            motorcycle.manufcture_date = request.manufcture_date;
            motorcycle.model = request.model;
            motorcycle.engine_id = request.engine_id;
            motorcycle.plate_number = request.plate_number;
            motorcycle.gear_id = request.gear_id;
            motorcycle.body_serial_number = request.body_serial_number;
            motorcycle.body_serial_number = request.body_serial_number;
            motorcycle.tier_diameter = request.tier_diameter;

            motorcycle.length = request.length;

            motorcycle.is_deleted = request.is_deleted;
            motorcycle.deleted_at = request.deleted_at;
            motorcycle.TRIAL424 = request.TRIAL424;
            _dbcontext.Entry(motorcycle).State = EntityState.Modified;
            _dbcontext.SaveChanges();
            return Ok(motorcycle);
        }
        [HttpDelete("DeleteMotorcycle/{id}")]
        public IActionResult DeleteMotorcycle( int id)
        {
            var motorcycle = _dbcontext.Motorcycle.FirstOrDefault(x => x.motorcycle_id == id);
            _dbcontext.Entry(motorcycle).State = EntityState.Deleted;
            _dbcontext.SaveChanges();
            return Ok(motorcycle);

        }

    }
}
