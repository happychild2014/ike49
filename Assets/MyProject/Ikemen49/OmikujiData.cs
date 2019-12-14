using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OmikujiData : MonoBehaviour
{
    public List<Omikuji> data = new List<Omikuji>()
    {
        //0
        new Omikuji() {
            upText = "ヨモギ蒸しをやるのだ",
            bottomText = "場所を変えての身体のメンテナンスは、\n自分のリラクゼーションになるよ",
            spriteName = "yomogi_girl"
        },

        //1
        new Omikuji() {
            upText = "腰回りを\n自分でマッサージするのだ",
            bottomText = "自分で自分の体を知ること。\nそして自分をほぐしてみよう☆",
            spriteName = "massage_girl"
        },

        //2
        new Omikuji() {
            upText = "カイロを貼ろう",
            bottomText = "時間がお金が無くても\nミニカイロなら簡単に温まるよ。\nレディの身体は冷やしちゃダメ☆",
            spriteName = "cairo_girl"
        },

        //3
        new Omikuji() {
            upText = "ゆるもう",
            bottomText = "身体も心も締め付けないで\nゆるめてみよう。\n  Happyになる脈が育っていくよ☆",
            spriteName = "yurumu_girl"
        },

        //4
        new Omikuji() {
            upText = "カルマ粒（抑圧感情）\nたまってない？",
            bottomText = "カルマ粒は\n「身体を温める」→「本音を言う」\nのステップで溶けるよ。",
            spriteName = "harau_girl"
        },


        //////////////
        

        //5
        new Omikuji() {
            upText = "寝なさい",
            bottomText = "疲れてたり、寝たかったら\n温活よりも何よりもまずは寝ること。\n 自分が満たされて\n自分軸がぶれなくなるから。",
            spriteName = "ikemen_shiro"
        },

       //6
        new Omikuji() {
            upText = "好きなら好きって言え",
            bottomText = "あなたには口がある。\nあなたから自分の好きに近づいて行って\n「好き。」って言ってみよう。",
            spriteName = "ikemen_shiro"
        },

         //7
        new Omikuji() {
            upText = "つらい人生本気で変えたかったら\n・・・体を温めよう",
            bottomText = "身体が温まると\n思考の受容力が身について\n人生のタイミングが合ってくる",
            spriteName = "ikemen_shiro"
        },


        //8
        new Omikuji() {
            upText = "自分を愛する以上に\n人を愛せない。",
            bottomText = "自分を知った分だけ、\n人から愛される。",
            spriteName = "ikemen_shiro"
        },


        //9
        new Omikuji() {
            upText = "ほんとの事言えよ",
            bottomText = "自分の目からは逃げられない。\n自分をごまかさないで人に伝えてみよう。\n話してみよう。",
            spriteName = "ikemen_shiro"
        },

////////

        //10
        new Omikuji() {
            upText = "岩盤浴へ行こう",
            bottomText = "誰かと一緒に行ってもいいよね。\n一日のんびりしない？",
            spriteName = "ikemen_v"
        },

     

        //11
        new Omikuji() {
            upText = "素直になれよ",
            bottomText = "自分の為に生きていいんだよ。",
            spriteName = "ikemen_v"
        },

        //12
        new Omikuji() {
            upText = "自分のNoが言えたら、他人のNoも\n受け入れらるようになるんだよ",
            bottomText = "自分のNoを知る事。\n回数重ねたらNoの伝え方も上達するよ。\nたくさん失敗して楽しく生きよう。",
            spriteName = "ikemen_v"
        },

        //13
        new Omikuji() {
            upText = "とりあえずコーヒーでも飲んで\nほっとしよ？",
            bottomText = "好きな事がわからなかったら。\n自分がほっとするだけで、運命は変わる。\n小さな欲や幸せを集めて。",
            spriteName = "ikemen_v"
        },

        //14
        new Omikuji() {
            upText = "自分が光りなよ☆",
            bottomText = "自分を生きる覚悟は出来てる？\n心の充実があなたを心から光らせる。",
            spriteName = "ikemen_v"
        },
 
        
        //////////
       
        //15
        new Omikuji() {
            upText = "嫌いって言えたら\n初めて大好きがやってくる",
            bottomText = "好きを知るには、嫌いを知ること。",
            spriteName = "ikemen_megane"
        },



        //16
        new Omikuji() {
            upText = "血液の循環が良ければ\n人脈、金脈、情報脈が育つ",
            bottomText = "血流のめぐりは気のめぐり。\n身体を温めると気のめぐりが良くなるから\n必要なモノが引き寄せられる。",
            spriteName = "ikemen_megane"
        },



        //17
        new Omikuji() {
            upText = "現実が良くなければそれは嘘",
            bottomText = "自分に嘘をついている分だけ、\n現実にも満足しないよ。\n片っ端から好きを試そう。",
            spriteName = "ikemen_megane"
        },


        //18
        new Omikuji() {
            upText = "まずは自分。\nそして次のSTEPは調和。",
            bottomText = "自分の感情は女性性。\n  女性性を大事にできたら次は調和（男性性）。\n 自分と周りの間の心地良いポジションを\n自分で探していこう。",
            spriteName = "ikemen_megane"
        },


        //19
        new Omikuji() {
            upText = "好きな人が振り向いてくれないのは\n自分が自分を見ていないから",
            bottomText = "自分が自分にしている事が、現実を作る。",
            spriteName = "ikemen_megane"
        },


//////////


        //20
        new Omikuji() {
            upText = "断捨離してみよ？",
            bottomText = "もの捨て上手になると\n好き嫌いがはっきり分かるから\n自分に自信が持てるようになる。",
            spriteName = "ikemen_noudan"
        },


        //21
        new Omikuji() {
            upText = "自分を\n良くみせなくてもいいよ",
            bottomText = "ありのままの自分の気持ちを信じて。",
            spriteName = "ikemen_noudan"
        },


        //22
        new Omikuji() {
            upText = "自分以外の人に\n頼って・・・みなよ",
            bottomText = "普段頼れない人は、頼ること。\n頼ってばかりの人は自分の足で立つこと。\nバランスが大事。",
            spriteName = "ikemen_noudan"
        },

        //23
        new Omikuji() {
            upText = "自分に嘘つかない。",
            bottomText = "たったそれだけの事で、\n人生の風通しが良くなるよ",
            spriteName = "ikemen_noudan"
        },


      //24
        new Omikuji() {
            upText = "思い切り暴れてもいいよ。\n全部はき出しちゃいな！",
            bottomText = "感情を出せない人は、感情を出す事が大事。\n 感情を出し過ぎる人は、一旦立ち止まろう。\n自分の中のイケメンと\n相談するんだよ。"
            ,
            spriteName = "ikemen_noudan"
        },


////////



        //25
        new Omikuji() {
            upText = "ほんっっっきの運命の出会いをしたいなら\n自分の本音を見るのが先",
            bottomText = "本当の自分を出したその先に\n運命の相手を\n自分が見極めれる様になる。",
            spriteName = "ikemen_suits"
        },
      



        //26
        new Omikuji() {
            upText = "本当は愛されたいんじゃないの？",
            bottomText = "スネないで。\n自分は愛されたいって当たり前。\n認めてみよう。",
            spriteName = "ikemen_suits"
        },



        //27
        new Omikuji() {
            upText = "実際に何かやってみよう",
            bottomText = "実際に動く人に\n運命の扉は開かれる",
            spriteName = "ikemen_suits"
        },

        //28
        new Omikuji() {
            upText = "あせるなよ。",
            bottomText = "我慢した期間が長いと\n自分の感情が出るのに時間がかかる。\nあせりは禁物。\nあなたは着実に進んでいます。",
            spriteName = "ikemen_suits"
        },

   

        //29
        new Omikuji() {
            upText = "今日、好きなもの食べた？",
            bottomText = "自分の本音がわからないなら、\n毎瞬毎瞬、本気の好きを選べてるか\n意識してみて。",
            spriteName = "ikemen_suits"
        },

         
        
    };

    public Text menuText;
    public Text commentText;
    public Image characterImage;

    private void Start()
    {
        int randomNo = Random.Range(0, 30);

        menuText.text = data[randomNo].upText;
        commentText.text = data[randomNo].bottomText;

        characterImage.sprite= Resources.Load<Sprite>("pic/" + data[randomNo].spriteName);

    }


}






