using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_.NET_PracticeTask2
{
    class Rectangle
    {
        private double xUpLeft;
        private double yUpLeft;
        private double xDownRight;
        private double yDownRight;

        public Rectangle(double xUpLeft, double yUpLeft, double xDownRight, double yDownRight)
        {
            if (xUpLeft > xDownRight || yUpLeft < yDownRight)
            {
                throw new Exception("Incorrect point of rectangle"); 
            }

            this.xUpLeft = xUpLeft;
            this.yUpLeft = yUpLeft;
            this.xDownRight = xDownRight;
            this.yDownRight = yDownRight;
        }

        public void ReSizeRectangle(double coeff)
        {
            double xLength = this.xDownRight - this.xUpLeft;
            double yLength = this.yUpLeft - this.yDownRight;

            this.xDownRight = this.xUpLeft + coeff * xLength ;
            this.yDownRight = this.yUpLeft - coeff * yLength;
        }

        public void MoveRectangle(double xMove,double yMove)
        {
            this.xUpLeft += xMove;
            this.yUpLeft += yMove;
            this.xDownRight += xMove;
            this.yDownRight += yMove;
        }

        public static Rectangle FindRectangleThatContains2Rectangles(Rectangle rect1,Rectangle rect2)
        {
            Rectangle resRectangle;
            double xUpLeftRes = rect1.xUpLeft < rect2.xUpLeft ? rect1.xUpLeft : rect2.xUpLeft;
            double xDownRigthRes = rect1.xDownRight > rect2.xDownRight ? rect1.xDownRight : rect2.xDownRight;
            double yUpLeftRes = rect1.yUpLeft > rect2.yUpLeft ? rect1.yUpLeft : rect2.yUpLeft;
            double yDownRightRes = rect1.yDownRight < rect2.yDownRight ? rect1.yDownRight : rect2.yDownRight; 

            resRectangle = new Rectangle(xUpLeftRes, yUpLeftRes, xDownRigthRes, yDownRightRes);
            return resRectangle;
        }

        public Rectangle IntersectionWithRectangle(Rectangle rectToIntersect)
        {
            Rectangle resRectangle;
            if (this.xDownRight < rectToIntersect.xUpLeft ||
                this.xUpLeft > rectToIntersect.xDownRight ||
                this.yUpLeft < rectToIntersect.yDownRight ||
                this.yDownRight > rectToIntersect.yUpLeft)
            {
                return resRectangle = null;
            }
            double _xDownRight = this.xDownRight > rectToIntersect.xDownRight ? rectToIntersect.xDownRight : this.xDownRight;
            double _xUpLeft = this.xUpLeft > rectToIntersect.xUpLeft ? this.xUpLeft : rectToIntersect.xUpLeft;
            double _yDownRight = this.yDownRight > rectToIntersect.yDownRight ? this.yDownRight : rectToIntersect.yDownRight;
            double _yUpLeft = this.yUpLeft > rectToIntersect.yUpLeft ? rectToIntersect.yUpLeft : this.yUpLeft;

            resRectangle = new Rectangle(_xUpLeft,_yUpLeft,_xDownRight, _yDownRight);    
            return resRectangle;
        }

        public override string ToString()
        {
            return "(" + Math.Round(xUpLeft, 2) + ";" + Math.Round(yUpLeft, 2) + ")\t(" + Math.Round(xDownRight, 2) + ";" + Math.Round(yUpLeft, 2) + ")\n(" +
                Math.Round(xUpLeft, 2) + ";" + Math.Round(yDownRight, 2) + ")\t(" + Math.Round(xDownRight, 2) + ";" + Math.Round(yDownRight, 2) + ")";
        }

    }
}
