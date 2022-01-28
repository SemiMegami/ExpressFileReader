using System;
using OSM_File_Reader;
using OSM_Geometry;
using ThreeDMaker;
namespace OSM_Project_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            osm osm = new osm();
            osm.ImportXML("../../../../../AIT TU.osm");
            MeshMaker maker = new MeshMaker(osm);

            var buildings = maker.GetBuildings();
            buildings.ReCalculateNormal();
            buildings.ExportToObj("../../../../../buildings.obj",true);
        }
    }
}
