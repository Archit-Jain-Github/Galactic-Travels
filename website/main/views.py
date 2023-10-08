from django.shortcuts import render
from django.http import HttpResponse
from django.urls import reverse

# Create your views here.

def index(request):
    return render(request, 'main/index.html')

def planets(request):
    return render(request, 'main/planets.html')

def planetarium(request):
    return render(request, 'main/planetarium.html')

def services(request):
    return render(request, 'main/services.html')

def spaceVoyage(request):
    return render(request, 'main/spaceVoyage.html')

def vision(request):
    return render(request, 'main/vision.html')

def contact(request):
    if request.method=='POST':
        return render(request, "main/contact.html", {
            'message': 'Information submitted. You will be contacted soon.',
        })
    return render(request, 'main/contact.html')

def earth(request):
    return render(request, 'main/earth.html')

def mercury(request):
    return render(request, 'main/mercury.html')

def venus(request):
    return render(request, 'main/venus.html')

def mars(request):
    return render(request, 'main/mars.html')

def jupiter(request):
    return render(request, 'main/jupiter.html')

def saturn(request):
    return render(request, 'main/saturn.html')

def uranus(request):
    return render(request, 'main/uranus.html')

def neptune(request):
    return render(request, 'main/neptune.html')

def sun(request):
    return render(request, 'main/sun.html')

def moon(request):
    return render(request, 'main/moon.html')

def solar(request):
    return render(request, 'main/solar.html')