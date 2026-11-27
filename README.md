# Unity Tetris

Unity / C# で実装したテトリスです。盤面の描画に Tilemap を使っています。
このリポジトリには、メインスクリプト `Tetris.cs` のみを収録しています（Unity プロジェクト一式ではありません）。

![tetris](https://github.com/go656/UnityTetris/assets/38488306/a04b9046-0ea0-4d84-8225-80cc7ff8cde7)

## 実装していること

- テトリミノ 7 種（I / O / S / Z / J / L / T）、各種 4 方向の回転形を `Vector2Int` 配列で定義
- Tilemap を役割ごとに分離
  - `falling`: 落下中のブロック
  - `fallen`: 積み上がったブロック
  - `walls`: 壁
  - `info`: 次のブロック（NEXT）表示
- 当たり判定は `fallen` と `walls` のタイル有無で判定
- ライン消去: 横 10 マスが揃ったら消去し、上を 1 段ずつ落とす
- スコア: 消したライン数を表示。消すたびに落下速度が少し速くなる（`Time.fixedDeltaTime *= 0.99f`）
- ゲームオーバー処理: 出現位置で衝突したら盤面とスコアをリセット
- 回転時の簡易ウォールキック: 横に `0, -1, +1, +2` ずらして回せる位置を探す

## 操作方法（ゲームパッド）

現在のコードは **ゲームパッド専用** です。`Gamepad.current` がない場合は動作しません。
キーボード操作のコードはコメントアウトされた状態で残っています。

| 入力 | 動作 |
|---|---|
| 十字キー 左 / 右 | 左右へ移動 |
| 十字キー 下 | ハードドロップ（一番下まで落とす） |
| 左スティック | 左右・上下へ移動 |
| □ ボタン | 回転 |
| × ボタン | ブロックの種類を切り替える（実装上の操作） |

## 動かし方

1. Unity で 2D プロジェクトを作成する
   - ※ 開発時の Unity バージョンはこのリポジトリには記録されていません。分かる範囲でここに追記してください: `[要記入: Unity xxxx.x]`
2. パッケージとして TextMeshPro と Input System を用意する
   （`Tetris.cs` は `TMPro` と `UnityEngine.InputSystem` を使用）
3. シーンに Tilemap を 4 つ（`info` / `falling` / `fallen` / `walls`）と、各テトリミノ用の Tile、スコア表示用の `Text` を配置する
4. 空の GameObject 等に `Tetris.cs` をアタッチし、Inspector で上記の Tilemap / Tile / Text / AudioSource を割り当てる
5. 壁の Tilemap に盤面の壁タイルを配置してから実行する

## ファイル構成

| ファイル | 内容 |
|---|---|
| `Tetris.cs` | テトリミノ定義（`Tetriminos` クラス）とゲーム本体（`Tetris` クラス）すべて |

## 補足

- BGM 用の `AudioSource` 参照はありますが、速度に応じたピッチ変更は現在コメントアウトされています。
