using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Color = Entities.Concrete.Color;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();

        IDataResult<Color> GetByColorId(int colorId);

        IResult Add (Color color);

        IResult Delete(Color color);

        IResult Update(Color color);


        
    }
}
