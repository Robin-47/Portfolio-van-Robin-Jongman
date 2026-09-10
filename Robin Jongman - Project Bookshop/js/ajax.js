/* JavaScript voor het filteren.*/

function loadBooks() {
    // Lees de gezochte titel en de gekozen filters.
    let searchInput = document.getElementById('search-input');
    let title = searchInput ? searchInput.value : '';
    let checkedCats = document.querySelectorAll('input[name="categories[]"]:checked');
    let checkedAuthors = document.querySelectorAll('input[name="authors[]"]:checked');

    const formData = new FormData();
    formData.append('title', title);
    checkedCats.forEach(cb => formData.append('categories[]', cb.value));
    checkedAuthors.forEach(cb => formData.append('authors[]', cb.value));

    fetch("boek-filter.php", {
        method: 'POST',
        body: formData
    })
    .then(response => response.text())
    .then(htmlContent => {
        let overview = document.getElementById("overview");
        if (overview) overview.innerHTML = htmlContent;
    })
    .catch(error => {
        console.error('Fout bij laden boeken:', error);
        let overview = document.getElementById("overview");
        if (overview) overview.innerHTML = '<p style="color: red;">Fout bij laden boeken.</p>';
    });
}

function loadAuthors() {
    // Lees de gezochte titel en de gekozen filters.
    let searchInput = document.getElementById('search-input');
    let title = searchInput ? searchInput.value : '';
    let checkedCats = document.querySelectorAll('input[name="categories[]"]:checked');
    let checkedAuthors = document.querySelectorAll('input[name="authors[]"]:checked');

    const formData = new FormData();
    formData.append('title', title);
    checkedCats.forEach(cb => formData.append('categories[]', cb.value));
    checkedAuthors.forEach(cb => formData.append('authors[]', cb.value));

    fetch("auteur-filter.php", {
        method: 'POST',
        body: formData
    })
    .then(response => response.text())
    .then(htmlContent => {
        let authorFilter = document.getElementById("author-filter");
        if (authorFilter) authorFilter.innerHTML = htmlContent;
    })
    .catch(error => {
        console.error('Fout bij laden auteurs:', error);
        let authorFilter = document.getElementById("author-filter");
        if (authorFilter) authorFilter.innerHTML = '<p style="color: red;">Fout bij laden auteurs.</p>';
    });
}

function loadOverview() {
    // Laat de pagina de boeken en de auteurs tegelijk vernieuwen.
    loadBooks();
    loadAuthors();
}
