$(document).ready(function () {
    ParseDocument(TestDocument);
    adjustPageWidth();
});

var isResizeActive = false;



ParseDocument = function (data) {
    // Split out page and run each page separately
    for (i in data.Pages) {
        page = RenderPage(data.Pages[i]);
        $(".main").append(page);
        
    }

}

RenderPage = function (data) {
    var page = $("<div></div>").addClass("page");
    for (i in data.Lines) {
        var line = RenderLine(data.Lines[i]);
        page.append(line);
        // add to page items to page before returning
    }
    return page;
}

RenderLine = function (data) {
    var l = $("<span></span>")
    l.addClass("line");
    l.text(data.Text);
    var left = CalcXOffset(data.xOffset);
    var top = CalcYOffset(data.yOffset);
    l.css("left", left + "%");
    l.css("top", top + "%");
    if (data.font != undefined && data.font != null) {
        console.log("has font");
        l.css("font-family", "IMB");
        l.css("font-size", "16pt");
    }
    if (data.type != undefined && data.type != null) {
        l.addClass("dontprint");
    }
    return l;
}

CalcXOffset = function (x) {
    // assuming all in inches currently
    return (x / 8.5)*100;
}

CalcYOffset = function (y) {
    // assuming all in inches currently
    return (y / 11)*100;
}

handleResize = function () {
    if (isResizeActive) {
        return;
    }
    isResizeActive = true;

}

adjustPageWidth = function () {
    var pageWidth = $(".page")[0].getBoundingClientRect().width;
    var CalculatedHeight = Math.floor(pageWidth * (11 / 8.5));
    $(".page").css("height", CalculatedHeight + "px");
}
