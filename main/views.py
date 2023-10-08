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
    return render(request, 'main/contact.html')