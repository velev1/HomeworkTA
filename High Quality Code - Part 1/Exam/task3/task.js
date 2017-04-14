function solve() {
    return '<div id="tabs">' +
    '{{#each titles}}' +
    '<li class="list-item">' +
    '<label for="tab-1" class="title">{{titles.text}}</label>' + 
    '</li>' +
    '{{/each}}' +
    '</div>';
}

if(typeof module !== 'undefined') {
	module.exports = solve;
}
