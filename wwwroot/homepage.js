const mobileMenuIcon = document.getElementById('mobile-menu-icon');
const mobileNav = document.getElementById('mobile-nav');

mobileMenuIcon.addEventListener('click', function () {
    if (mobileNav.style.display === 'block' || mobileNav.style.display === '') {

        mobileNav.style.display = 'none';
    } else {
        mobileNav.style.display = 'block';
    }
});
