using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess.Concrete;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;

        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }



        [ValidationAspect(typeof(ImageValidator))]
        public IResult Add(Image image)
        {
            _imageDal.Add(image);
            return new SuccessResult(Messages.ImageAdded);
        }

        public IResult Delete(Image image)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Image> Get()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Image>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Image image)
        {
            throw new NotImplementedException();
        }
    }
}
