using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {

            ValidationTool.Validate(new CarValidator(), car);

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);


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



        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>
            (_carDal.GetAll(c => c.DailyPrice <= min && c.DailyPrice >= max));
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

        public IResult Update(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        IResult ICarService.Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.CarId == carId));
        }





        //public IDataResult<List<CarImagesDto>> GetCarImages(int carId)
        //{
        //    return new SuccessDataResult<List<CarImagesDto>>(_carDal.GetCarImages(carId));
        //}
    }
}
