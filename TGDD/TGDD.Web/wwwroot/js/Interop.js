
var autoScrollIntervalId;
function initializeThumbnailAutoScroll(dotNetReference, interval) {
    const boxes = document.querySelectorAll('.carousel .box img');
    if (boxes.length === 0) {
        return; // Exit if boxes are not available
    }

    if (autoScrollIntervalId) {
        clearInterval(autoScrollIntervalId);
    }

    autoScrollIntervalId = setInterval(() => {
        dotNetReference.invokeMethodAsync('GetCurrentActiveIndex')
            .then((currentIndex) => {
                /*console.log('Current Index from Blazor:', currentIndex);*/

                let nextIndex = (currentIndex + 1) % boxes.length;
                /*console.log('Next Index:', nextIndex);*/

                // Update UI based on the next index
                boxes.forEach(box => box.parentNode.classList.remove('active'));
                boxes[nextIndex].parentNode.classList.add('active');
                dotNetReference.invokeMethodAsync('SetMainImage', boxes[nextIndex].src);
                boxes[nextIndex].parentNode.scrollIntoView({ behavior: 'smooth', block: 'nearest', inline: 'start' });

                // Increment the index in Blazor component
                dotNetReference.invokeMethodAsync('IncrementActiveIndex');
            });
    }, interval);

    return autoScrollIntervalId;
}

function initializeThumbnailDrag() {
    const slider = document.getElementById("carousel-thumbnail-strip");
    let isDown = false;
    let startX;
    let scrollLeft;

    slider.addEventListener('mousedown', (e) => {
        isDown = true;
        slider.classList.add('active');
        startX = e.pageX - slider.offsetLeft;
        scrollLeft = slider.scrollLeft;
    });
    slider.addEventListener('mouseleave', () => {
        isDown = false;
        slider.classList.remove('active');
    });
    slider.addEventListener('mouseup', () => {
        isDown = false;
        slider.classList.remove('active');
    });
    slider.addEventListener('mousemove', (e) => {
        if (!isDown) return;
        e.preventDefault();
        const x = e.pageX - slider.offsetLeft;
        const walk = (x - startX) * 3; //scroll-fast
        slider.scrollLeft = scrollLeft - walk;
        //console.log(walk);
    });
}

function cleanupThumbnailStrip() {
    const slider = document.getElementById("carousel-thumbnail-strip");
    if (slider) {
        // Remove event listeners if any were added
        slider.removeEventListener('mousedown', handleMouseDown);
        slider.removeEventListener('mouseleave', handleMouseLeave);
        slider.removeEventListener('mouseup', handleMouseUp);
        slider.removeEventListener('mousemove', handleMouseMove);
    }
}

function clearAutoScrollInterval() {
    if (autoScrollIntervalId) {
        clearInterval(autoScrollIntervalId);
    }
}

function bindCarouselControls() {
    var prevButton = document.getElementById('prevButton');
    var nextButton = document.getElementById('nextButton');
    var carouselElement = document.getElementById('carouselBanner');

    if (carouselElement) {
        var carouselInstance = new bootstrap.Carousel(carouselElement, {
            // Carousel options if needed
        });

        if (prevButton && nextButton) {
            prevButton.addEventListener('click', function () {
                carouselInstance.prev();
            });

            nextButton.addEventListener('click', function () {
                carouselInstance.next();
            });
        }
    }
}


