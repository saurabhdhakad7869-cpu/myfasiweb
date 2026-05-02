// ===========================
// 1. NAVBAR SCROLL EFFECT
// ===========================
const navbar = document.querySelector('.navbar');

window.addEventListener('scroll', () => {
  if (window.scrollY > 50) {
    navbar.style.background = 'rgba(10, 10, 10, 0.98)';
    navbar.style.borderBottom = '1px solid rgba(255, 165, 0, 0.35)';
    navbar.style.boxShadow = '0 4px 30px rgba(0,0,0,0.5)';
  } else {
    navbar.style.background = 'rgba(10, 10, 10, 0.85)';
    navbar.style.borderBottom = '1px solid rgba(255, 165, 0, 0.15)';
    navbar.style.boxShadow = 'none';
  }
});


// ===========================
// 2. SCROLL FADE-IN ANIMATION
// ===========================
const fadeElements = document.querySelectorAll('.skill-card, .contact-card, .hero-text, .hero-image');

// Pehle sab hide karo
fadeElements.forEach(el => {
  el.style.opacity = '0';
  el.style.transform = 'translateY(30px)';
  el.style.transition = 'opacity 0.6s ease, transform 0.6s ease';
});

// Observer — jab screen pe aaye tab show karo
const observer = new IntersectionObserver((entries) => {
  entries.forEach((entry, index) => {
    if (entry.isIntersecting) {
      // Thoda delay dete hain har card ko
      setTimeout(() => {
        entry.target.style.opacity = '1';
        entry.target.style.transform = 'translateY(0)';
      }, index * 120);
      observer.unobserve(entry.target);
    }
  });
}, {
  threshold: 0.15
});

fadeElements.forEach(el => observer.observe(el));


// ===========================
// 3. SKILL BAR ANIMATION
// ===========================
const skillFills = document.querySelectorAll('.skill-fill');

const skillObserver = new IntersectionObserver((entries) => {
  entries.forEach(entry => {
    if (entry.isIntersecting) {
      const fill = entry.target;
      const targetWidth = fill.style.width; // e.g. "90%"

      // Pehle 0 pe rakh
      fill.style.width = '0%';
      fill.style.transition = 'width 1.4s cubic-bezier(0.4, 0, 0.2, 1)';

      // Thodi der baad fill karo
      setTimeout(() => {
        fill.style.width = targetWidth;
      }, 200);

      skillObserver.unobserve(fill);
    }
  });
}, {
  threshold: 0.3
});

skillFills.forEach(fill => skillObserver.observe(fill));


// ===========================
// 4. BONUS: 3D TILT ON NAME
// ===========================
const name3d = document.querySelector('.name-3d');

if (name3d) {
  name3d.addEventListener('mousemove', (e) => {
    const rect = name3d.getBoundingClientRect();
    const x = e.clientX - rect.left - rect.width / 2;
    const y = e.clientY - rect.top - rect.height / 2;

    const rotateX = -(y / rect.height) * 12;
    const rotateY = (x / rect.width) * 12;

    name3d.style.transform = `perspective(600px) rotateX(${rotateX}deg) rotateY(${rotateY}deg)`;
    name3d.style.transition = 'transform 0.1s ease';
  });

  name3d.addEventListener('mouseleave', () => {
    name3d.style.transform = 'perspective(600px) rotateX(0deg) rotateY(0deg)';
    name3d.style.transition = 'transform 0.4s ease';
  });
}


// ===========================
// 5. BONUS: ACTIVE NAV LINK
// ===========================
const sections = document.querySelectorAll('section');
const navLinks = document.querySelectorAll('.nav-links a');

window.addEventListener('scroll', () => {
  let current = '';

  sections.forEach(section => {
    const sectionTop = section.offsetTop - 100;
    if (window.scrollY >= sectionTop) {
      current = section.getAttribute('id');
    }
  });

  navLinks.forEach(link => {
    link.style.color = '#ccc';
    if (link.getAttribute('href') === `#${current}`) {
      link.style.color = '#FFA500';
    }
  });
});
                 
