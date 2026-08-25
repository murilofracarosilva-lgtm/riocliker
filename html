<!DOCTYPE html>
<html lang="pt-BR">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Dino Adventure</title>

<style>

*{
    margin:0;
    padding:0;
    box-sizing:border-box;
}

body{
    display:flex;
    justify-content:center;
    align-items:center;
    height:100vh;

    background:linear-gradient(
        to bottom,
        #87CEEB,
        #B0E0E6,
        #E0F6FF
    );

    overflow:hidden;
    font-family:Arial, sans-serif;
}

#game{
    position:relative;
    width:900px;
    height:300px;
    overflow:hidden;
}

/* SOL */

#sun{
    position:absolute;
    top:20px;
    right:50px;

    width:80px;
    height:80px;

    border-radius:50%;

    background:#FFD700;

    box-shadow:
        0 0 30px #FFD700,
        0 0 60px #FFD700;
}

/* NUVENS */

.cloud{
    position:absolute;
    width:100px;
    height:40px;
    background:white;
    border-radius:50px;
}

.cloud1{
    top:40px;
    animation:cloudMove 25s linear infinite;
}

.cloud2{
    top:80px;
    animation:cloudMove 40s linear infinite;
}

@keyframes cloudMove{
    from{
        left:100%;
    }
    to{
        left:-150px;
    }
}

/* MONTANHAS */

.mountains{
    position:absolute;
    bottom:40px;
    width:100%;
    height:180px;
}

.mountain{
    position:absolute;
    bottom:0;

    width:0;
    height:0;

    border-left:120px solid transparent;
    border-right:120px solid transparent;
}

.m1{
    left:20px;
    border-bottom:180px solid #7c8db5;
}

.m2{
    left:250px;
    border-bottom:220px solid #6a7da8;
}

.m3{
    left:550px;
    border-bottom:170px solid #8093bb;
}

/* CHÃO */

.grass{
    position:absolute;
    bottom:0;

    width:100%;
    height:40px;

    background:linear-gradient(
        to bottom,
        #63d471,
        #2e8b57
    );
}

/* DINOSSAURO */

#dino{

    position:absolute;
    left:50px;
    bottom:40px;

    width:50px;
    height:60px;

    background:#2ecc71;

    border-radius:12px;

    z-index:10;
}

.eye{
    position:absolute;

    width:8px;
    height:8px;

    background:black;

    border-radius:50%;

    top:15px;
    right:10px;
}

.jump{
    animation:jump 500ms linear;
}

@keyframes jump{

    0%{
        bottom:40px;
    }

    50%{
        bottom:160px;
    }

    100%{
        bottom:40px;
    }

}

/* CACTO */

#cactus{
    position:absolute;

    width:35px;
    height:70px;

    right:-50px;
    bottom:40px;

    background:linear-gradient(
        to bottom,
        #0f8b25,
        #006400
    );

    border-radius:5px;

    animation:moveCactus 2s linear infinite;

    z-index:10;
}

@keyframes moveCactus{

    from{
        right:-50px;
    }

    to{
        right:1000px;
    }

}

/* SCORE */

#score{
    position:absolute;
    top:10px;
    right:20px;

    font-size:28px;
    font-weight:bold;
    color:#333;
}

</style>
</head>
<body>

<div id="game">

    <div id="sun"></div>

    <div class="cloud cloud1"></div>
    <div class="cloud cloud2"></div>

    <div class="mountains">

        <div class="mountain m1"></div>
        <div class="mountain m2"></div>
        <div class="mountain m3"></div>

    </div>

    <div class="grass"></div>

    <div id="score">0</div>

    <div id="dino">
        <div class="eye"></div>
    </div>

    <div id="cactus"></div>

</div>

<script>

const dino = document.getElementById("dino");
const cactus = document.getElementById("cactus");
const scoreElement = document.getElementById("score");

let score = 0;
let gameOver = false;

/* PULO */

document.addEventListener("keydown", function(e){

    if(
        (e.code === "Space" || e.code === "ArrowUp")
        &&
        !dino.classList.contains("jump")
    ){

        dino.classList.add("jump");

        setTimeout(() => {
            dino.classList.remove("jump");
        },500);

    }

});

/* SCORE */

const scoreInterval = setInterval(() => {

    if(!gameOver){

        score++;
        scoreElement.textContent = score;

    }

},100);

/* COLISÃO */

const collision = setInterval(() => {

    const dinoBottom =
        parseInt(
            window
            .getComputedStyle(dino)
            .getPropertyValue("bottom")
        );

    const cactusRect =
        cactus.getBoundingClientRect();

    const dinoRect =
        dino.getBoundingClientRect();

    if(

        cactusRect.left < dinoRect.right &&
        cactusRect.right > dinoRect.left &&
        cactusRect.bottom > dinoRect.top &&
        dinoBottom < 100

    ){

        gameOver = true;

        cactus.style.animation = "none";

        alert(
            "GAME OVER!\nPontuação: " + score
        );

        clearInterval(collision);
        clearInterval(scoreInterval);

    }

},10);

</script>

</body>
</html>
