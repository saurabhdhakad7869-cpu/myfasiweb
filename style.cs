/* ===========================
   RESET & BASE
=========================== */
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

html {
  scroll-behavior: smooth;
}

body {
  font-family: 'DM Sans', sans-serif;
  background-color: #0a0a0a;
  color: #f0f0f0;
  overflow-x: hidden;
}

/* ===========================
   NAVBAR
=========================== */
.navbar {
  position: fixed;
  top: 0;
  width: 100%;
  z-index: 999;
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 18px 60px;
  background: rgba(10, 10, 10, 0.85);
  backdrop-filter: blur(12px);
  border-bottom: 1px solid rgba(255, 165, 0, 0.15);
}

.nav-logo {
  font-family: 'Playfair Display', serif;
  font-size: 28px;
  font-weight: 900;
  color: #FFA500;
  letter-spacing: 2px;
}

.nav-links {
  list-style: none;
  display: flex;
  gap: 40px;
}

.nav-links a {
  text-decoration: none;
  color: #ccc;
  font-size: 15px;
  font-weight: 500;
  letter-spacing: 1px;
  transition: color 0.3s;
}

.nav-links a:hover {
  color: #FFA500;
}

/* ===========================
   HERO SECTION
=========================== */
.hero {
  min-height: 100vh;
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 120px 60px 80px;
  gap: 40px;
}

.hero-text {
  flex: 1;
  max-width: 560px;
}

.hello-tag {
  font-size: 16px;
  color: #FFA500;
  letter-spacing: 2px;
  margin-bottom: 16px;
  font-weight: 500;
}

/* ===========================
   3D TEXT EFFECT — MAIN NAME
=========================== */
.name-3d {
  font-family: 'Playfair Display', serif;
  font-size: clamp(56px, 8vw, 100px);
  font-weight: 900;
  line-height: 1.05;
  color: #ffffff;
  text-shadow:
    1px 1px 0px #cccccc,
    2px 2px 0px #aaaaaa,
    3px 3px 0px #888888,
    4px 4px 0px #666666,
    5px 5px 0px #444444,
    6px 6px 0px #222222,
    7px 7px 15px rgba(0,0,0,0.6);
  margin-bottom: 20px;
  transition: text-shadow 0.3s ease;
}

.name-3d:hover {
  text-shadow:
    1px 1px 0px #FFA500,
    2px 2px 0px #e69500,
    3px 3px 0px #cc8400,
    4px 4px 0px #b37300,
    5px 5px 0px #996200,
    6px 6px 0px #805100,
    8px 8px 20px rgba(255, 165, 0, 0.4);
  color: #fff;
}

.hero-role {
  font-size: 22px;
  font-weight: 300;
  color: #aaa;
  margin-bottom: 16px;
  letter-spacing: 1px;
}

.highlight {
  color: #FFA500;
  font-weight: 600;
}

.hero-desc {
  font-size: 16px;
  color: #888;
  line-height: 1.8;
  margin-bottom: 36px;
  max-width: 420px;
}

/* HERO BUTTONS */
.hero-btns {
  display: flex;
  gap: 16px;
  flex-wrap: wrap;
}

.btn-whatsapp {
  display: inline-flex;
  align-items: center;
  gap: 8px;
  padding: 14px 28px;
  background: #25D366;
  color: #fff;
  text-decoration: none;
  border-radius: 8px;
  font-weight: 600;
  font-size: 15px;
  letter-spacing: 0.5px;
  transition: transform 0.2s, box-shadow 0.2s;
  box-shadow: 0 4px 20px rgba(37, 211, 102, 0.3);
}

.btn-whatsapp:hover {
  transform: translateY(-3px);
  box-shadow: 0 8px 30px rgba(37, 211, 102, 0.5);
}

.btn-telegram {
  display: inline-flex;
  align-items: center;
  gap: 8px;
  padding: 14px 28px;
  background: #0088cc;
  color: #fff;
  text-decoration: none;
  border-radius: 8px;
  font-weight: 600;
  font-size: 15px;
  letter-spacing: 0.5px;
  transition: transform 0.2s, box-shadow 0.2s;
  box-shadow: 0 4px 20px rgba(0, 136, 204, 0.3);
}

.btn-telegram:hover {
  transform: translateY(-3px);
  box-shadow: 0 8px 30px rgba(0, 136, 204, 0.5);
}

/* HERO IMAGE */
.hero-image {
  flex: 1;
  display: flex;
  justify-content: center;
  align-items: center;
}

.dev-img {
  width: 100%;
  max-width: 420px;
  border-radius: 20px;
  border: 2px solid rgba(255, 165, 0, 0.25);
  box-shadow:
    0 0 40px rgba(255, 165, 0, 0.1),
    0 20px 60px rgba(0, 0, 0, 0.6);
  transition: transform 0.4s ease, box-shadow 0.4s ease;
}

.dev-img:hover {
  transform: scale(1.03) rotateY(3deg);
  box-shadow:
    0 0 60px rgba(255, 165, 0, 0.25),
    0 30px 80px rgba(0, 0, 0, 0.7);
}

/* ===========================
   SKILLS SECTION
=========================== */
.skills {
  padding: 100px 60px;
  background: #0f0f0f;
}

/* 3D TEXT EFFECT — SECTION TITLES */
.section-title-3d {
  font-family: 'Playfair Display', serif;
  font-size: clamp(36px, 5vw, 60px);
  font-weight: 900;
  text-align: center;
  margin-bottom: 60px;
  color: #ffffff;
  text-shadow:
    1px 1px 0px #FFA500,
    2px 2px 0px #e69500,
    3px 3px 0px #cc8400,
    4px 4px 0px #7a4f00,
    5px 5px 12px rgba(0,0,0,0.5);
}

.skills-grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(240px, 1fr));
  gap: 28px;
  max-width: 1100px;
  margin: 0 auto;
}

.skill-card {
  background: #1a1a1a;
  border: 1px solid rgba(255, 165, 0, 0.12);
  border-radius: 16px;
  padding: 32px 28px;
  transition: transform 0.3s ease, border-color 0.3s ease, box-shadow 0.3s ease;
}

.skill-card:hover {
  transform: translateY(-8px) rotateX(3deg);
  border-color: rgba(255, 165, 0, 0.5);
  box-shadow: 0 16px 40px rgba(255, 165, 0, 0.12);
}

.skill-icon {
  font-size: 36px;
  display: block;
  margin-bottom: 16px;
}

.skill-card h3 {
  font-size: 18px;
  font-weight: 600;
  color: #f0f0f0;
  margin-bottom: 10px;
}

.skill-card p {
  font-size: 14px;
  color: #777;
  line-height: 1.7;
  margin-bottom: 20px;
}

.skill-bar {
  height: 5px;
  background: #2a2a2a;
  border-radius: 999px;
  overflow: hidden;
}

.skill-fill {
  height: 100%;
  background: linear-gradient(90deg, #FFA500, #FFD700);
  border-radius: 999px;
  animation: fillBar 1.5s ease forwards;
  transform-origin: left;
}

@keyframes fillBar {
  from { width: 0% !important; }
  to   { /* width stays as inline style */ }
}

/* ===========================
   CONTACT SECTION
=========================== */
.contact {
  padding: 100px 60px;
  background: #0a0a0a;
  text-align: center;
}

.contact-sub {
  color: #777;
  font-size: 16px;
  margin-top: -40px;
  margin-bottom: 50px;
}

.contact-cards {
  display: flex;
  justify-content: center;
  gap: 28px;
  flex-wrap: wrap;
}

.contact-card {
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 10px;
  padding: 40px 50px;
  border-radius: 20px;
  text-decoration: none;
  width: 240px;
  transition: transform 0.3s ease, box-shadow 0.3s ease;
}

.whatsapp-card {
  background: rgba(37, 211, 102, 0.08);
  border: 1px solid rgba(37, 211, 102, 0.25);
}

.whatsapp-card:hover {
  transform: translateY(-8px);
  box-shadow: 0 20px 50px rgba(37, 211, 102, 0.2);
}

.telegram-card {
  background: rgba(0, 136, 204, 0.08);
  border: 1px solid rgba(0, 136, 204, 0.25);
}

.telegram-card:hover {
  transform: translateY(-8px);
  box-shadow: 0 20px 50px rgba(0, 136, 204, 0.2);
}

.contact-icon {
  font-size: 42px;
}

.contact-card h3 {
  font-size: 18px;
  font-weight: 700;
  color: #f0f0f0;
}

.contact-card p {
  font-size: 14px;
  color: #888;
}

.contact-action {
  font-size: 13px;
  color: #FFA500;
  font-weight: 600;
  letter-spacing: 0.5px;
  margin-top: 6px;
}

/* ===========================
   FOOTER
=========================== */
.footer {
  text-align: center;
  padding: 28px;
  background: #050505;
  color: #444;
  font-size: 13px;
  border-top: 1px solid #1a1a1a;
}

/* ===========================
   RESPONSIVE — MOBILE
=========================== */
@media (max-width: 768px) {
  .navbar {
    padding: 16px 24px;
  }

  .nav-links {
    gap: 20px;
  }

  .hero {
    flex-direction: column;
    padding: 100px 24px 60px;
    text-align: center;
  }

  .hero-desc {
    margin: 0 auto 30px;
  }

  .hero-btns {
    justify-content: center;
  }

  .dev-img {
    max-width: 300px;
  }

  .skills {
    padding: 70px 24px;
  }

  .contact {
    padding: 70px 24px;
  }
  }
  
