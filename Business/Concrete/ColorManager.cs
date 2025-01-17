﻿using Business.Abstract;
using Business.Business.BuisnessAspects;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager: IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        [SecuredOperation("color.add,admin")]
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult();
        }

        [SecuredOperation("color.delete,admin")]
        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult();
        }

        [SecuredOperation("color.update,admin")]
        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult();
        }
        public IDataResult<List<Color>> GetColors()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }
        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == id));
        }

    }
}
    

