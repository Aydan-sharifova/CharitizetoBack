const loader = document.getElementById("loader");
const navLinks = document.getElementById("navLinks");
const menuToggle = document.getElementById("menuToggle");
const backToTop = document.getElementById("backToTop");

window.addEventListener("load", () => {
    setTimeout(() => loader.classList.add("hidden"), 250);
});

menuToggle.addEventListener("click", () => {
    navLinks.classList.toggle("open");
});

navLinks.querySelectorAll("a").forEach((link) => {
    link.addEventListener("click", () => navLinks.classList.remove("open"));
});

const setActiveNav = () => {
    const sections = ["top", "about", "services", "donation", "events", "team", "contact"];
    let active = "top";

    sections.forEach((id) => {
        const section = document.getElementById(id);
        if (section && section.getBoundingClientRect().top <= 120) {
            active = id;
        }
    });

    navLinks.querySelectorAll("a").forEach((link) => {
        link.classList.toggle("active", link.getAttribute("href") === `#${active}`);
    });
};

const toggleBackToTop = () => {
    backToTop.classList.toggle("visible", window.scrollY > 420);
};

window.addEventListener("scroll", () => {
    setActiveNav();
    toggleBackToTop();
});

backToTop.addEventListener("click", () => {
    window.scrollTo({ top: 0, behavior: "smooth" });
});

function createSlider(slides, prevButton, nextButton, interval = 5500) {
    let index = 0;
    let timer;

    const show = (nextIndex) => {
        slides[index].classList.remove("active");
        index = (nextIndex + slides.length) % slides.length;
        slides[index].classList.add("active");
    };

    const restart = () => {
        clearInterval(timer);
        timer = setInterval(() => show(index + 1), interval);
    };

    prevButton.addEventListener("click", () => {
        show(index - 1);
        restart();
    });

    nextButton.addEventListener("click", () => {
        show(index + 1);
        restart();
    });

    restart();
}

createSlider(
    document.querySelectorAll(".hero-slide"),
    document.getElementById("heroPrev"),
    document.getElementById("heroNext")
);

createSlider(
    document.querySelectorAll(".testimonial"),
    document.getElementById("testPrev"),
    document.getElementById("testNext"),
    6500
);

const revealObserver = new IntersectionObserver((entries) => {
    entries.forEach((entry) => {
        if (entry.isIntersecting) {
            entry.target.classList.add("visible");
            revealObserver.unobserve(entry.target);
        }
    });
}, { threshold: 0.15 });

document.querySelectorAll(".reveal").forEach((item) => revealObserver.observe(item));

const counterObserver = new IntersectionObserver((entries) => {
    entries.forEach((entry) => {
        if (!entry.isIntersecting) return;

        const counter = entry.target;
        const target = Number(counter.dataset.counter);
        const duration = 1600;
        const start = performance.now();

        const tick = (time) => {
            const progress = Math.min((time - start) / duration, 1);
            const eased = 1 - Math.pow(1 - progress, 3);
            counter.textContent = Math.floor(eased * target).toLocaleString();

            if (progress < 1) {
                requestAnimationFrame(tick);
            } else {
                counter.textContent = target.toLocaleString();
            }
        };

        requestAnimationFrame(tick);
        counterObserver.unobserve(counter);
    });
}, { threshold: 0.5 });

document.querySelectorAll("[data-counter]").forEach((counter) => counterObserver.observe(counter));

const videoModal = document.getElementById("videoModal");
const videoFrame = document.getElementById("videoFrame");
const videoUrl = "https://www.youtube.com/embed/DWRcNpR6Kdc";

document.getElementById("playVideo").addEventListener("click", () => {
    videoFrame.src = `${videoUrl}?autoplay=1&modestbranding=1`;
    videoModal.classList.add("open");
    videoModal.setAttribute("aria-hidden", "false");
});

function closeVideo() {
    videoModal.classList.remove("open");
    videoModal.setAttribute("aria-hidden", "true");
    videoFrame.src = "";
}

document.getElementById("closeVideo").addEventListener("click", closeVideo);
videoModal.addEventListener("click", (event) => {
    if (event.target === videoModal) closeVideo();
});

document.addEventListener("keydown", (event) => {
    if (event.key === "Escape" && videoModal.classList.contains("open")) {
        closeVideo();
    }
});

const amounts = document.getElementById("amounts");
amounts.addEventListener("click", (event) => {
    if (event.target.tagName !== "BUTTON") return;
    amounts.querySelectorAll("button").forEach((button) => button.classList.remove("selected"));
    event.target.classList.add("selected");
});

document.querySelector(".donate-form").addEventListener("submit", (event) => {
    event.preventDefault();
    const selectedAmount = amounts.querySelector(".selected").textContent;
    document.getElementById("donateNote").textContent = `Thank you. Your ${selectedAmount} donation choice is ready.`;
});

document.getElementById("newsletterForm").addEventListener("submit", (event) => {
    event.preventDefault();
    document.getElementById("newsletterNote").textContent = "Thanks for subscribing.";
    event.target.reset();
});

setActiveNav();
toggleBackToTop();
