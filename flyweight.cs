using System.Collections;
using System.Collections.Generic;

public class Terrain
{
    private int _numberOfTrees;
    private int _movementCost;
    private bool _impassable;
    public Terrain(int trees, int cost, bool isImpassable)
    {
        _numberOfTrees = trees;
        _movementCost = cost;
        _impassable = isImpassable;
    }
}

public class World
{
    private Terrain[][] _worldTiles;
    private Terrain _water;
    private Terrain _mountains;
    private Terrain _grass;

    public World(File file)
    {
        _water = new Terrain(0, 0, true);
        _mountain = new Terrain(2, 5, false);
        _grass = new Terrain(10, 2,false);

        LoadTilesFromFile(file);
    }

    private LoadTilesFromFile(File file)
    {
        _worldTiles = new Terrain[file.worldWidth][file.worldHeight]();
        for(int i = 0; i < file.worldWidth; i++){
            for(int j = 0; j < file.worldHeight; j++){
                _worldTiles[i][j] = AssignTerrain(file.terrainData[i][j])
            }
        }
    }

    private Terrain AssignTerrain(int tag)
    {
        switch(tag)
        {
            case 1:
                return _water;
            case 2:
                return _mountain;
            default:
                return _grass;            
        }
    }

}

public class File
{
    public int worldWidth;
    public int worldHeight;
    public int[][] terrainData;
}
