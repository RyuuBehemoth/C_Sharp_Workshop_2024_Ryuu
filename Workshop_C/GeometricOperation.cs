namespace Workshop_C;

public class GeometricOperation
{
    // 1. Calculate the area of a circle given its radius
    public double CalculateCircleArea(double radius)
    {
        // TODO: Implement
        if (radius < 0)
        {
            return 0;
        }
        else
        {
            double circleArea = double.Pi * Math.Pow(radius, 2);
            double circleAreaResult = Math.Round(circleArea, 2);
            return circleAreaResult;
        }
    }

// 2. Calculate the circumference of a circle given its radius
    public double CalculateCircleCircumference(double radius)
    {
        // TODO: Implement
        double circumference = 2 * double.Pi * radius;
        double circumferenceResult = Math.Round(circumference, 2);
        return circumferenceResult;
    }

// 3. Calculate the area of a rectangle given its width and height
    public double CalculateRectangleArea(double width, double height)
    {
        // TODO: Implement
        double rentagleArea = width * height;
        return rentagleArea;
    }

// 4. Calculate the perimeter of a rectangle given its width and height
    public double CalculateRectanglePerimeter(double width, double height)
    {
        // TODO: Implement
        double rectanglePerimeter = 2 * (width + height);
        return rectanglePerimeter;
    }

// 5. Calculate the area of a triangle given its base and height
    public double CalculateTriangleArea(double baseLength, double height)
    {
        // TODO: Implement
        double triangleArea =(baseLength * height)/2;
        return triangleArea;
    }

// 6. Calculate the perimeter of a triangle given its three sides
    public double CalculateTrianglePerimeter(double side1, double side2, double side3)
    {
        // TODO: Implement
        double trianglePerimeter = side1 + side2 + side3;
        return trianglePerimeter;
    }

// 7. Calculate the area of a square given its side length
    public double CalculateSquareArea(double side)
    {
        // TODO: Implement
        double squareArea =(side*side);
        return squareArea;
    }

// 8. Calculate the perimeter of a square given its side length
    public double CalculateSquarePerimeter(double side)
    {
        double squarePerimeter =(4*side);
        return squarePerimeter;
        // TODO: Implement
    }

// 9. Calculate the length of the hypotenuse of a right triangle given the other two sides
    public double CalculateHypotenuse(double sideA, double sideB)
    {
        // TODO: Implement
        if ((sideA == 0) || (sideB == 0))
        {
            return 0;
        }
        else
        {
            double hypoteneuse = Math.Sqrt((Math.Pow(sideA, 2)) + (Math.Pow(sideB, 2)));
            return hypoteneuse;
        }
    }

// 10. Calculate the area of a trapezoid given its bases and height
    public double CalculateTrapezoidArea(double base1, double base2, double height)
    {
        // TODO: Implement
        double trapezoidArea = ((base1 + base2)*height)/2;
        return trapezoidArea;
    }

// 11. Calculate the volume of a cylinder given its radius and height
    public double CalculateCylinderVolume(double radius, double height)
    {
        // TODO: Implement
        double cylinderVolume = Math.PI * Math.Pow(radius,2) * height;
        return cylinderVolume;
    }

// 12. Calculate the volume of a cube given its side length
    public double CalculateCubeVolume(double side)
    {
        // TODO: Implement
        double cubeVolume = Math.Pow(side,3);
        return cubeVolume;
    }

// 13. Calculate the volume of a sphere given its radius
    public double CalculateSphereVolume(double radius)
    {
        // TODO: Implement
        double sphereVolume = (4 * (Math.PI) * (Math.Pow(radius,3)))/3;
        return sphereVolume;
    }

// 14. Calculate the surface area of a cylinder given its radius and height
    public double CalculateCylinderSurfaceArea(double radius, double height)
    {
        // TODO: Implement
        double cylinderSurface = (2 * (Math.PI) * radius * height) + (2* Math.PI * Math.Pow(radius,2));
        return cylinderSurface;
    }

// 15. Calculate the surface area of a cube given its side length
    public double CalculateCubeSurfaceArea(double side)
    {
        // TODO: Implement
        double cubeSurface = 6 * Math.Pow(side,2);
        return cubeSurface;
    }

// 16. Calculate the surface area of a sphere given its radius
    public double CalculateSphereSurfaceArea(double radius)
    {
        // TODO: Implement
        double sphereSurface = (4 * (Math.PI) * Math.Pow(radius, 2));
        return sphereSurface;
    }

// 17. Calculate the volume of a cone given its radius and height
    public double CalculateConeVolume(double radius, double height)
    {
        // TODO: Implement
        double coneVolume = (Math.PI * Math.Pow(radius, 2) * height)/3;
        return coneVolume;
    }

// 18. Calculate the volume of a pyramid given its base and height
    public double CalculatePyramidVolume(double baseArea, double height)
    {
        // TODO: Implement
        double pyramidVolume = (baseArea * height) / 3;
        return pyramidVolume;
    }

// 19. Calculate the area of a regular polygon given its number of sides and side length
    public double CalculateRegularPolygonArea(int numSides, double sideLength)
    {
        // TODO: Implement
        if (numSides == 0)
        {
            return 0;
        }
        else
        {
            double angle = (360 / (2 * numSides));
            angle = angle * (Math.PI / 180);
            double apotem = (sideLength / (2 * Math.Tan(angle)));
            double perimeter = numSides * sideLength;
            double regularPolygonArea = (perimeter * apotem) / 2;
            return regularPolygonArea;
        }
    }

// 20. Calculate the perimeter of a regular polygon given its number of sides and side length
    public double CalculateRegularPolygonPerimeter(int numSides, double sideLength)
    {
        // TODO: Implement
        double regularPolygonPerimeter = numSides * sideLength;
        return regularPolygonPerimeter;
    }

// 21. Check if three sides can form a triangle
    public bool CanFormTriangle(double side1, double side2, double side3)
    {
        if ((side1 + side2) > side3)
        {
            return true;
        }
        else 
        { 
            return false;
        }
    }

// 22. Calculate the area of a parallelogram given its base and height
    public double CalculateParallelogramArea(double baseLength, double height)
    {
        double parallelogramArea = baseLength * height;
        return parallelogramArea;
    }

// 23. Calculate the perimeter of a parallelogram given its base and sides
    public double CalculateParallelogramPerimeter(double baseLength, double sideLength)
    {
        double parallelogramPerimeter = 2 * (baseLength + sideLength);
        return parallelogramPerimeter;
    }

// 24. Check if four sides can form a rectangle
    public bool CanFormRectangle(double side1, double side2, double side3, double side4)
    {
        if ((side1 == side3) && (side2 == side4))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

// 25. Calculate the diagonal of a rectangle given its width and height
    public double CalculateRectangleDiagonal(double width, double height)
    {
        if (width == 0)
        {
            return height;
        }
        else
        {
            double rectangleDiagonal = CalculateHypotenuse(width, height);
            return rectangleDiagonal;
        }
    }

// 26. Check if a set of points form a right triangle
    public bool IsRightTriangle(double sideA, double sideB, double hypotenuse)
    {
        if ((Math.Pow(sideA,2) + Math.Pow(sideB,2)) == Math.Pow(hypotenuse,2))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

// 27. Calculate the area of an ellipse given its major and minor axes
    public double CalculateEllipseArea(double majorAxis, double minorAxis)
    {
        double ellipseArea = Math.PI * majorAxis * minorAxis;
        return ellipseArea;
    }

// 28. Check if three angles can form a triangle (sum of angles must be 180 degrees)
    public bool CanFormTriangleFromAngles(double angle1, double angle2, double angle3)
    {
        if (angle1 != 0 && angle2 != 0 && angle3 != 0)
        {
            if ((angle1 + angle2 + angle3) == 180)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

// 29. Calculate the surface area of a cone given its radius and slant height
    public double CalculateConeSurfaceArea(double radius, double slantHeight)
    {
        double coneSurfaceArea = (Math.PI * radius * slantHeight) + (Math.PI * Math.Pow(radius,2));
        return coneSurfaceArea;
    }

// 30. Calculate the perimeter of an ellipse given its major and minor axes
    public double CalculateEllipsePerimeter(double majorAxis, double minorAxis)
    {
        if ((majorAxis == 0) || (minorAxis == 0))
        {
            return 0;
        }
        else
        {
            double ellipsePerimeter = (Math.PI) * ((3 * (majorAxis + minorAxis)) - Math.Sqrt(((3 * majorAxis) + minorAxis) * (majorAxis + (3 * minorAxis))));
            ellipsePerimeter = Math.Round(ellipsePerimeter, 0);
            return ellipsePerimeter;
        }
    }

// 31. Use the Law of Cosines to find the third side given two sides and the included angle
    public double CalculateThirdSideLawOfCosines(double sideA, double sideB, double angleDegrees)
    {
        if (sideA == 0 || sideB == 0)
        {
            return 0;
        }
        else
        {
            double angleRadian = (Math.PI * angleDegrees) / 180;
            double thirdSide = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - (2 * sideA * sideB * Math.Cos(angleRadian)));
            return thirdSide;   //respuesta incorrecta y corregida en clase
        }
    }

// 32. Use the Law of Cosines to find an angle given three sides of a triangle
    public double CalculateAngleLawOfCosines(double sideA, double sideB, double sideC)
    {
        double angleLawCosines = Math.Acos((Math.Pow(sideA,2) - Math.Pow(sideB,2) - Math.Pow(sideC,2))/(-2 * sideB * sideC));
        return angleLawCosines; //respuesta incorrecta
    }

// 33. Use the Law of Sines to find a side given an angle and its opposite side
    public double CalculateSideLawOfSines(double angleA, double sideA, double angleB)
    {
        if (sideA == 0)
        {
            return double.NaN;
            return 0;   //pide retornar 0 y NaN
        }
        else
        {
            angleA = (Math.PI * angleA) / 180;
            angleB = (Math.PI * angleB) / 180;
            double sideB = (sideA * Math.Sin(angleB)) / (Math.Sin(angleA));
            return sideB;
        }
    }

// 34. Use the Law of Sines to find an angle given two angles and one side
    public double CalculateAngleLawOfSines(double angleA, double angleB, double sideC)
    {
        angleA = (Math.PI * angleA)/180;
        angleB = (Math.PI * angleB)/180;
        double angleC = 0; //esta mal planteado
        return 0;
    }

// 35. Find the area of a triangle given two sides and the included angle using the Law of Cosines
    public double CalculateTriangleAreaWithCosine(double sideA, double sideB, double angleDegrees)
    {
        double angleRadian = (Math.PI * angleDegrees)/180;
        double triangleAreaCosine = (sideA * sideB * Math.Sin(angleRadian))/2;
        return triangleAreaCosine;
    }

// 36. Check if three sides can form a triangle using the Law of Cosines
    public bool CanFormTriangleWithCosines(double sideA, double sideB, double sideC)
    {
        double angleA = ((Math.Acos((Math.Pow(sideA, 2) - Math.Pow(sideB, 2) - Math.Pow(sideC, 2)) / (-2 * sideB * sideC))) * 180)/Math.PI;
        double angleB = ((Math.Acos((Math.Pow(sideB, 2) - Math.Pow(sideA, 2) - Math.Pow(sideC, 2)) / (-2 * sideA * sideC))) * 180) / Math.PI;
        double angleC = ((Math.Acos((Math.Pow(sideC, 2) - Math.Pow(sideA, 2) - Math.Pow(sideB, 2)) / (-2 * sideA * sideB))) * 180) / Math.PI;
        if ((angleA + angleB + angleC) == 180)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

// 37. Calculate the perimeter of a triangle using the Law of Cosines
    public double CalculateTrianglePerimeterWithCosines(double sideA, double sideB, double sideC)
    {

        return 0.0;
    }

// 38. Calculate the height of a triangle using the Law of Cosines
    public double CalculateTriangleHeightWithCosines(double sideA, double angleDegrees)
    {
        return 0.0;
    }

// 39. Check if an angle is a right angle using the Law of Cosines
    public bool IsRightAngleWithCosines(double sideA, double sideB, double sideC)
    {
        return false;
    }

// 40. Calculate the area of a triangle given two sides and the included angle using the Law of Sines
    public double CalculateTriangleAreaWithSines(double angleA, double sideA, double sideB)
    {
        return 0.0;
    }
}