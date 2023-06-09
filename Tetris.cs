using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class Tetriminos
{
    public Vector2Int[][] I = new Vector2Int[][]
    {
        new Vector2Int[]
        {
            new Vector2Int(0, 1),
            new Vector2Int(0, 0),
            new Vector2Int(0, -1),
            new Vector2Int(0, -2)
        },
        new Vector2Int[]
        {
            new Vector2Int(1, 0),
            new Vector2Int(0, 0),
            new Vector2Int(-1, 0),
            new Vector2Int(-2, 0)
        },
        new Vector2Int[]
        {
            new Vector2Int(0, 1),
            new Vector2Int(0, 0),
            new Vector2Int(0, -1),
            new Vector2Int(0, -2)
        },
        new Vector2Int[]
        {
            new Vector2Int(1, 0),
            new Vector2Int(0, 0),
            new Vector2Int(-1, 0),
            new Vector2Int(-2, 0)
        }

    };

    public Vector2Int[][] O = new Vector2Int[][]
    {
        new Vector2Int[]
        {
            new Vector2Int(0, -1),
            new Vector2Int(0, 0),
            new Vector2Int(-1, 0),
            new Vector2Int(-1, -1)
        },
        new Vector2Int[]
        {
            new Vector2Int(0, -1),
            new Vector2Int(0, 0),
            new Vector2Int(-1, 0),
            new Vector2Int(-1, -1)
        },
        new Vector2Int[]
        {
            new Vector2Int(0, -1),
            new Vector2Int(0, 0),
            new Vector2Int(-1, 0),
            new Vector2Int(-1, -1)
        },
        new Vector2Int[]
        {
            new Vector2Int(0, -1),
            new Vector2Int(0, 0),
            new Vector2Int(-1, 0),
            new Vector2Int(-1, -1)
        }
    };

    public Vector2Int[][] S = new Vector2Int[][]
    {
        new Vector2Int[]
        {
            new Vector2Int(1, 0),
            new Vector2Int(0, 0),
            new Vector2Int(0, -1),
            new Vector2Int(-1, -1)
        },
        new Vector2Int[]
        {
            new Vector2Int(-1, 1),
            new Vector2Int(-1, 0),
            new Vector2Int(0, 0),
            new Vector2Int(0, -1)
        },
        new Vector2Int[]
        {
            new Vector2Int(1, 0),
            new Vector2Int(0, 0),
            new Vector2Int(0, -1),
            new Vector2Int(-1, -1)
        },
        new Vector2Int[]
        {
            new Vector2Int(-1, 1),
            new Vector2Int(-1, 0),
            new Vector2Int(0, 0),
            new Vector2Int(0, -1)
        }
    };

    public Vector2Int[][] Z = new Vector2Int[][]
    {
        new Vector2Int[]
        {
            new Vector2Int(-1, 0),
            new Vector2Int(0, 0),
            new Vector2Int(0, -1),
            new Vector2Int(1, -1)
        },
        new Vector2Int[]
        {
            new Vector2Int(0, 1),
            new Vector2Int(0, 0),
            new Vector2Int(-1, 0),
            new Vector2Int(-1, -1)
        },
        new Vector2Int[]
        {
            new Vector2Int(-1, 0),
            new Vector2Int(0, 0),
            new Vector2Int(0, -1),
            new Vector2Int(1, -1)
        },
        new Vector2Int[]
        {
            new Vector2Int(0, 1),
            new Vector2Int(0, 0),
            new Vector2Int(-1, 0),
            new Vector2Int(-1, -1)
        }
    };

    public Vector2Int[][] J = new Vector2Int[][]
    {
        new Vector2Int[]
        {
            new Vector2Int(0, 1),
            new Vector2Int(0, 0),
            new Vector2Int(0, -1),
            new Vector2Int(-1, -1)
        },
        new Vector2Int[]
        {
            new Vector2Int(-1, 0),
            new Vector2Int(-1, -1),
            new Vector2Int(0, -1),
            new Vector2Int(1, -1)
        },
        new Vector2Int[]
        {
            new Vector2Int(0, 1),
            new Vector2Int(-1, 1),
            new Vector2Int(-1, 0),
            new Vector2Int(-1, -1)
        },
        new Vector2Int[]
        {
            new Vector2Int(-1, 0),
            new Vector2Int(0, 0),
            new Vector2Int(1, 0),
            new Vector2Int(1, -1)
        }
    };

    public Vector2Int[][] L = new Vector2Int[][]
    {
        new Vector2Int[]
        {
            new Vector2Int(-1, 1),
            new Vector2Int(-1, 0),
            new Vector2Int(-1, -1),
            new Vector2Int(0, -1)
        },
        new Vector2Int[]
        {
            new Vector2Int(-1, -1),
            new Vector2Int(-1, 0),
            new Vector2Int(0, 0),
            new Vector2Int(1, 0)
        },
        new Vector2Int[]
        {
            new Vector2Int(-1, 1),
            new Vector2Int(0, 1),
            new Vector2Int(0, 0),
            new Vector2Int(0, -1)
        },
        new Vector2Int[]
        {
            new Vector2Int(-1, -1),
            new Vector2Int(0, -1),
            new Vector2Int(1, -1),
            new Vector2Int(1, 0)
        }
    };

    public Vector2Int[][] T = new Vector2Int[][]
    {
        new Vector2Int[]
        {
            new Vector2Int(-1, 0),
            new Vector2Int(0, 0),
            new Vector2Int(1, 0),
            new Vector2Int(0, -1)
        },
        new Vector2Int[]
        {
            new Vector2Int(0, 1),
            new Vector2Int(0, 0),
            new Vector2Int(0, -1),
            new Vector2Int(-1, 0)
        },
        new Vector2Int[]
        {
            new Vector2Int(-1, 0),
            new Vector2Int(0, 0),
            new Vector2Int(1, 0),
            new Vector2Int(0, 1)
        },
        new Vector2Int[]
        {
            new Vector2Int(0, 1),
            new Vector2Int(0, 0),
            new Vector2Int(0, -1),
            new Vector2Int(1, 0)
        },
    };

    public Vector2Int[][][] Blocks = new Vector2Int[7][][];

    public Tetriminos()
    {
        Blocks[0] = I;
        Blocks[1] = O;
        Blocks[2] = S;
        Blocks[3] = Z;
        Blocks[4] = J;
        Blocks[5] = L;
        Blocks[6] = T;
    }

    public Vector2Int[] Trans(int shape, int rot, int x, int y)
    {
        Vector2Int[] b = Blocks[shape][rot];
        Vector2Int[] ret = new Vector2Int[4];

        for (int i = 0; i < 4; i++)
        {
            ret[i].x = b[i].x + x;
            ret[i].y = b[i].y + y;
        }

        return ret;
    }

}

public class Tetris : MonoBehaviour
{

    public Tilemap info;
    public Tilemap falling;
    public Tilemap fallen;
    public Tilemap walls;
    public Tile tileI, tileO, tileS, tileZ, tileJ, tileL, tileT;
    public Text text;
    public AudioSource bgm;
    
    private Tile[] tiles = new Tile[7];
    private Tetriminos tetriminos = new Tetriminos();
    private int shape = 0, next_shape = 0;
    private int rot = 0, px = 0, py = 8;
    private int score = 0;

    private float axis_h = 0.0f, axis_v = 0.0f;
    private float speed_h = 10.0f, speed_v = 10.0f;

    private bool CheckCollide(int shape, int rot, int x, int y)
    {
        Vector2Int[] b = tetriminos.Trans(shape, rot, x, y);
        for (int i = 0; i < 4; i++)
        {
            if (fallen.HasTile(new Vector3Int(b[i].x, b[i].y))) return true;
            if (walls.HasTile(new Vector3Int(b[i].x, b[i].y))) return true;
        }
        return false;
    }

    private void UpdateFallingTile()
    {
        Vector2Int[] b = tetriminos.Trans(shape, rot, px, py);
        falling.ClearAllTiles();
        for (int i = 0; i < 4; i++)
        {
            falling.SetTile(new Vector3Int(b[i].x, b[i].y), tiles[shape]);
        }
    }

    private void UpdateNextTile()
    {
        Vector2Int[] b = tetriminos.Trans(next_shape, 0, 9, 7);
        info.ClearAllTiles();
        for (int i = 0; i < 4; i++)
        {
            info.SetTile(new Vector3Int(b[i].x, b[i].y), tiles[next_shape]);
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        tiles[0] = tileI;
        tiles[1] = tileO;
        tiles[2] = tileS;
        tiles[3] = tileZ;
        tiles[4] = tileJ;
        tiles[5] = tileL;
        tiles[6] = tileT;

        Time.fixedDeltaTime = 1.0f;
        shape = Random.Range(0, 7);
        next_shape = Random.Range(0, 7);

        UpdateFallingTile();
        UpdateNextTile();
    }

    // Update is called once per frame
    private void Update()
    {
        var gamepad = Gamepad.current;
        if (gamepad == null) return;

        //if (Input.GetKeyDown(KeyCode.Space))
        //if (Input.GetButtonDown("Submit"))
        if (gamepad.squareButton.wasPressedThisFrame)
        {
            int[] dx = { 0, -1, 1, 2};

            for (int i = 0; i < dx.Length; i++)
            {
                if (!CheckCollide(shape, (rot + 1) % 4, px + dx[i], py))
                {
                    rot = (rot + 1) % 4;
                    px += dx[i];
                    UpdateFallingTile();
                    break;
                }
            }
        }

        //if (Input.GetKeyDown(KeyCode.S) && !CheckCollide((shape + 1) % 7, rot, px, py))
        //if (Input.GetButtonDown("Cancel") && !CheckCollide((shape + 1) % 7, rot, px, py))
        if (gamepad.crossButton.wasPressedThisFrame)
        {
            shape = (shape + 1) % 7;
            UpdateFallingTile();
        }

        //if (Input.GetKeyDown("left") && !CheckCollide(shape, rot, px - 1, py))
        if (gamepad.dpad.left.wasPressedThisFrame && !CheckCollide(shape, rot, px - 1, py))
        {
            px--;
            UpdateFallingTile();
        }
        //else if (Input.GetKeyDown("right") && !CheckCollide(shape, rot, px + 1, py))
        else if (gamepad.dpad.right.wasPressedThisFrame && !CheckCollide(shape, rot, px + 1, py))
        {
            px++;
            UpdateFallingTile();
        }
        //else if (Input.GetKeyDown("up") && !CheckCollide(shape, rot, px, py + 1))
        else if (gamepad.dpad.up.wasPressedThisFrame && !CheckCollide(shape, rot, px, py + 1))
        {
            py++;
            UpdateFallingTile();
        }
        //else if (Input.GetKeyDown("down"))
        else if (gamepad.dpad.down.wasPressedThisFrame)
        {
            while(!CheckCollide(shape, rot, px, py - 1)) py--;
            UpdateFallingTile();
        }

        //axis_h += Input.GetAxis("Horizontal") * Time.deltaTime * speed_h;
        //axis_v += Input.GetAxis("Vertical") * Time.deltaTime * speed_v;

        axis_h += gamepad.leftStick.x.ReadValue() * Time.deltaTime * speed_h;
        axis_v += gamepad.leftStick.y.ReadValue() * Time.deltaTime * speed_v;

        if (axis_h < -1.0f)
        {
            if (!CheckCollide(shape, rot, px - 1, py))
            {
                px--;
                UpdateFallingTile();
            }
            axis_h = 0.0f;
        }
        else if (1.0f < axis_h)
        {
            if (!CheckCollide(shape, rot, px + 1, py))
            {
                px++;
                UpdateFallingTile();
            }
            axis_h = 0.0f;
        }
        else if (axis_v < -1.0f)
        {
            if (!CheckCollide(shape, rot, px, py - 1))
            {
                py--;
                UpdateFallingTile();
            }
            axis_v = 0.0f;
        }
        else if (1.0f < axis_v)
        {
            if (!CheckCollide(shape, rot, px, py + 1))
            {
                py++;
                UpdateFallingTile();
            }
            axis_v = 0.0f;
        }
    }

    private void FixedUpdate()
    {
        
        if (!CheckCollide(shape, rot, px, py - 1))
        {
            py--;
        }
        else
        {
            Vector2Int[] b = tetriminos.Trans(shape, rot, px, py);
            for (int i = 0; i < 4; i++)
            {
                fallen.SetTile(new Vector3Int(b[i].x, b[i].y), tiles[shape]);
            }

            for (int y = -10; y < 10; y++)
            {
                bool line = true;
                for (int x = -5; x < 5; x++)
                {
                    if (!fallen.HasTile(new Vector3Int(x, y)))
                    {
                        line = false;
                        break;
                    }
                }
                if (line)
                {
                    for (int line_y = y; line_y < 10; line_y++)
                    {
                        for (int x = -5; x < 5; x++)
                        {
                            TileBase tile = fallen.GetTile(new Vector3Int(x, line_y + 1));
                            fallen.SetTile(new Vector3Int(x, line_y), tile);
                        }
                    }
                    y--;
                    Time.fixedDeltaTime *= 0.99f;
                    //bgm.pitch *= 1.01f;
                    score++;
                    text.text = score.ToString();
                }
            }

            shape = next_shape;
            next_shape = Random.Range(0, 7);
            rot = 0;  px = 0; py = 8;

            UpdateNextTile();

            if (CheckCollide(shape, rot, px, py))
            {
                fallen.ClearAllTiles();
                Time.fixedDeltaTime = 1.0f;
                score = 0;
                text.text = score.ToString();
            }
        }
        
        UpdateFallingTile();
        
    }
}
