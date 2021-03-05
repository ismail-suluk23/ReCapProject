using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManagerBase
    { 
        ICarDal _carDal;


        public IResult Add(Car car)
        {

            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }
            return new ErrorResult(Messages.CarNameInvalid);

        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            //business code
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetAllByCarId(int id)
        {
            return new SuccessDataResult<List<Car>>
            (_carDal.GetAll(c => c.CarId == id));
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>
            (_carDal.GetAll(c => c.DailyPrice <= min && c.DailyPrice >= max));
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.CarId == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {

            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());

        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>
            (_carDal.GetAll(c => c.BrandId == brandId), Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>
            (_carDal.GetAll(c => c.ColorId == colorId), Messages.CarsListed);
        }

        public IResult Update(Car entity)
        {
            _carDal.Delete(entity);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}