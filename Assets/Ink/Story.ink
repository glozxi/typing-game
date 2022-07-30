VAR wpm = 0
Ow, my head...
I remember the car hitting the tree.
Must have gone off the road.
Hold on, where's Jim?
Dammit, he's unconscious, and bleeding too.
{wpm > 40: Geez, all that blood. | God, that's a lot of blood.}
I've got to get a bandage from the first aid kit.
Got it.
Now to tie it up around his head.
{wpm > 50: Done. | I'm not doing it fast enough!}
Time to call an ambulance.
Let's see. First number is...
Second...
{wpm > 50: Click. | Hands won't stop shaking. }
Third and last...
Hello?
{wpm > 50:
    -> Good
- else:
    -> Bad
}
=== Good ===
Now to wait.
-> END
=== Bad ===
Now to wait.
-> END
