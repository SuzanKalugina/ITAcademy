using Task1;
using Point = Task1.Point;

var coordinateSystem = new CoordinateSystemXY();

var point1 = new Point(2, 3);
var point2 = new Point(3, 4);

coordinateSystem.AddPoint(point1);
coordinateSystem.AddPoint(point2);
var lengthPoint1Point2 = CoordinateSystemXY.LengthPoints(point1, point2);
var countPoint = coordinateSystem.DotsCount();

Console.WriteLine($"Растояние между точками: {lengthPoint1Point2}");
Console.WriteLine($"Количество экземпларов типа Point: {countPoint}");