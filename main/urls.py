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
    path("earth", views.earth, name='earth'),
    path("mercury", views.mercury, name='mercury'),
    path("venus", views.venus, name='venus'),
    path("mars", views.mars, name='mars'),
    path("jupiter", views.jupiter, name='jupiter'),
    path("saturn", views.saturn, name='saturn'),
    path("uranus", views.uranus, name='uranus'),
    path("neptune", views.neptune, name='neptune'),
    path("moon", views.moon, name='moon'),
    path("sun", views.sun, name='sun'),
    path("solar", views.solar, name='solar'),
]