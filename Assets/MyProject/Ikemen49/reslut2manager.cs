using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class reslut2manager : MonoBehaviour
{

    public Text commentText;
    public Image todayPicture;
    public Sprite image0;
    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    public Sprite image4;
    public Sprite image5;
    public Sprite image6;
    public Sprite image7;
    public Sprite image8;
    public Sprite image9;
   

    string[] hitokoto = { "よもぎ蒸しをやるのだ", "腰回りを自分でマッサージするのだ", "カイロを貼ろう", "ゆるもう", "自分にカルマ粒（抑圧感情）たまってない？",
     "寝なさい", "岩盤浴へ行こう", "好きなら好きって言え", "つらい人生本気で変えたかったら。…身体を温めよう", "自分を愛する以上に人を愛せない",
     "素直になれよ", "ほんっっっきの運命の出会いをしたいなら、自分の本音を見るのが先", "苦手な人がいるなら、まだ本当の自分を生きてないんだよ", "嫌いって言えたら、初めて大好きがやってくる", "とりあえず、コーヒーでも飲んでほっとしよ？",
     "ほんとの事言えよ", "血流の循環が良ければ、人脈、金脈、情報脈が育つ。", "現実が良くならなければそれは嘘", "今日、好きな食べ物・・・、食べた？", "相手に対して言っている言葉は相手に言っている言葉。",
     "本当は愛されたいんじゃないの？", "自分のNoが言えたら、他人のNoも受け入れられるようになるんだよ", "自分以外の人に頼って・・・みなよ。", "自分に都合のいい環境作れよ", "寂しい人のアドバイスは聞くな。まずは遺文をなぐさめろ",
    "あるのままの自分を信じて", "好きな人が振り向いてくれないのは、自分が自分を見ていないから。", "実際に。何かやってみよう。", "身体温めたら、自分の感情出てくるから。焦らないで待ってみて。", "何かが入ってくる前に。捨てる作業も意識してみて"};


    // Use this for initialization
    void Start()
    {

        //ランダム数値 ←6月26日ランダムを指定したい
        int randomNo = Random.Range(0, 30);

        commentText.text = hitokoto[randomNo];

        //ランダムで指定した画像を表示

        //  string imgStr = "images/pic/" + randomNo;
        //  Sprite picture = Resources.Load<Sprite>(imgStr);

        // todayPicture.sprite = picture;

        switch (randomNo)
        {
            case 0:
                todayPicture.sprite = image0;
                break;

            case 1:
                todayPicture.sprite = image1;
                break;

            case 2:
                todayPicture.sprite = image2;
                break;

            case 3:
                todayPicture.sprite = image3;
                break;

            case 4:
                todayPicture.sprite = image4;
                break;
            case 5:
                todayPicture.sprite = image5;
                break;

            case 6:
                todayPicture.sprite = image5;
                break;

            case 7:
                todayPicture.sprite = image5;
                break;

            case 8:
                todayPicture.sprite = image5;
                break;

            case 9:
                todayPicture.sprite = image5;
                break;
            case 10:
                todayPicture.sprite = image6;
                break;

            case 11:
                todayPicture.sprite = image6;
                break;

            case 12:
                todayPicture.sprite = image6;
                break;

            case 13:
                todayPicture.sprite = image6;
                break;

            case 14:
                todayPicture.sprite = image6;
                break;
            case 15:
                todayPicture.sprite = image7;
                break;

            case 16:
                todayPicture.sprite = image7;
                break;

            case 17:
                todayPicture.sprite = image7;
                break;

            case 18:
                todayPicture.sprite = image7;
                break;

            case 19:
                todayPicture.sprite = image7;
                break;
            case 20:
                todayPicture.sprite = image8;
                break;

            case 21:
                todayPicture.sprite = image8;
                break;

            case 22:
                todayPicture.sprite = image8;
                break;

            case 23:
                todayPicture.sprite = image8;
                break;

            case 24:
                todayPicture.sprite = image8;
                break;
            case 25:
                todayPicture.sprite = image9;
                break;

            case 26:
                todayPicture.sprite = image9;
                break;

            case 27:
                todayPicture.sprite = image9;
                break;

            case 28:
                todayPicture.sprite = image9;
                break;

            case 29:
                todayPicture.sprite = image9;
                break;
        }
    }
}
    
                

                



