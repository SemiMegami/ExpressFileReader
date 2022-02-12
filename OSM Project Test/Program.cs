using System;
using OSM_File_Reader;
using OSM_Geometry;
using ThreeDMaker.Geometry;
using System.Collections;
using System.Collections.Generic;

namespace OSM_Project_Test
{
    class Program
    {
        static void Main(string[] args)
        {
 
            osm osm = new osm();
            osm.ImportXML("../../../../../AITIS.osm");

            

            MeshMaker maker = new MeshMaker(osm);
            maker.SetLatlong(366162075);
            var buildings = maker.GetBuildings();
            buildings.ReCalculateNormal();
            buildings.ExportToObj("../../../../../buildings.obj",true);

            var parkings = maker.GetParkings();
            parkings.ReCalculateNormal();
            parkings.ExportToObj("../../../../../parkings.obj", true);

            var roads = maker.GetRoad();
            roads.ReCalculateNormal();
            roads.ExportToObj("../../../../../highways.obj", true);
            var waters = maker.GetWater();
            waters.ReCalculateNormal();
            waters.ExportToObj("../../../../../waters.obj", true);
            var lands = maker.GetWaterCutLand();
            lands.ReCalculateNormal();
            lands.ExportToObj("../../../../../Lands.obj", true);

            var parks = maker.GetParks();
            parks.ReCalculateNormal();
            parks.ExportToObj("../../../../../parks.obj", true);

            var pitchs = maker.GetPitch();
            pitchs.ReCalculateNormal();
            pitchs.ExportToObj("../../../../../pitchs.obj", true);

            var grasslands = maker.GetGrasslands();
            grasslands.ReCalculateNormal();
            grasslands.ExportToObj("../../../../../grasslands.obj", true);

            List<Mesh3D> meshs = new List<Mesh3D>() { buildings, roads, waters,parkings ,parks, pitchs, grasslands };

            Mesh3D All = new Mesh3D(meshs);
            All.ReCalculateNormal();
            All.ExportToObj("../../../../../Map.obj", true);



        }
    }
}
