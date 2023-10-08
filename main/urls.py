from django.urls import path
from . import views

urlpatterns = [
    path("", views.index, name="index"),
    path("planets", views.planets, name="planets"),
    path("planetarium", views.planetarium, name='planetarium'),
    path("services", views.services, name='services'),
    path("spaceVoyage", views.spaceVoyage, name='spaceVoyage'),
    path("vision", views.vision, name='vision'),
    path("contact", views.contact, name='contact'),
]