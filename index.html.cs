<!DOCTYPE html>
<html lang="pt-BR">
<head>
  <meta charset="UTF-8">
  <title>Jogo do Dinossauro</title>
  <style>
    body {
      display: flex;
      flex-direction: column;
      align-items: center;
      justify-content: center;
      min-height: 100vh;
      margin: 0;
      background-color: #f7f7f7;
      font-family: Arial, sans-serif;
    }
    #gameCanvas {
      border-bottom: 2px solid #535353;
      background-color: #ffffff;
    }
    .instructions {
      margin-top: 15px;
      color: #535353;
    }
  </style>
</head>
<body>

  <canvas id="gameCanvas" width="600" height="200"></canvas>
  <p class="instructions">Pressione <strong>Espaço</strong> ou <strong>Seta para Cima</strong> para pular.</p>

  <script>
    const canvas = document.getElementById('gameCanvas');
    const ctx = canvas.getContext('2d');

    let isPlaying = true;
    let score = 0;
    let frame = 0;

    const dino = {
      x: 50,
      y: 150,
      width: 20,
      height: 40,
      dy: 0,
      gravity: 0.6,
      jumpForce: -10,
      grounded: true
    };

    const obstacles = [];

    function spawnObstacle() {
      obstacles.push({
        x: canvas.width,
        y: 160,
        width: 15,
        height: 30,
        speed: 5
      });
    }

    function jump() {
      if (dino.grounded && isPlaying) {
        dino.dy = dino.jumpForce;
        dino.grounded = false;
      } else if (!isPlaying) {
        resetGame();
      }
    }

    function resetGame() {
      score = 0;
      obstacles.length = 0;
      isPlaying = true;
      dino.y = 150;
      dino.dy = 0;
      dino.grounded = true;
      requestAnimationFrame(update);
    }

    document.addEventListener('keydown', (e) => {
      if (e.code === 'Space' || e.code === 'ArrowUp') {
        e.preventDefault();
        jump();
      }
    });

    function update() {
      if (!isPlaying) return;

      ctx.clearRect(0, 0, canvas.width, canvas.height);

      // Gravidade e Pulo
      dino.dy += dino.gravity;
      dino.y += dino.dy;

      if (dino.y >= 150) {
        dino.y = 150;
        dino.dy = 0;
        dino.grounded = true;
      }

      // Desenhar personagem
      ctx.fillStyle = '#535353';
      ctx.fillRect(dino.x, dino.y, dino.width, dino.height);

      // Gerar cactos periodicamente
      frame++;
      if (frame % 90 === 0) {
        spawnObstacle();
      }

      // Atualizar obstáculos
      for (let i = obstacles.length - 1; i >= 0; i--) {
        const obs = obstacles[i];
        obs.x -= obs.speed;

        // Desenhar obstáculo
        ctx.fillStyle = '#ff4d4d';
        ctx.fillRect(obs.x, obs.y, obs.width, obs.height);

        // Detecção de colisão
        if (
          dino.x < obs.x + obs.width &&
          dino.x + dino.width > obs.x &&
          dino.y < obs.y + obs.height &&
          dino.y + dino.height > obs.y
        ) {
          isPlaying = false;
          ctx.fillStyle = '#333';
          ctx.font = '18px Arial';
          ctx.fillText('Game Over! Pressione Espaço para reiniciar.', 110, 100);
        }

