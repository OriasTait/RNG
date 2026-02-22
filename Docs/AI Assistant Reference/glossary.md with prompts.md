The document glossary.md is a "new" file introduced after the other 7 were given anchor prompts.  Is there a standard prompt for this file?



Yes — and it’s good you’re asking this \*\*before\*\* starting the new chat.



`glossary.md` was introduced later because once you move into multi-solution + AI-heavy generation, terminology drift becomes a real problem.



It is not part of the original 7 because:



\* The original 7 control behavior and structure.

\* The glossary controls semantic stability.



It is a precision tool.



---



\# Why Glossary Exists



Without a glossary, AI will:



\* Redefine “Core”

\* Confuse “Application” with “Infrastructure”

\* Blur “Adapter” vs “Service”

\* Mix “Host” and “UI”

\* Use “Sync” inconsistently



That causes architectural erosion.



Glossary prevents that.



---



\# Where Glossary Fits in Order



It should be generated \*\*before constraints.md\*\*.



Why?



Because constraints and requirements rely on stable terminology.



So your new strict Day 0 order becomes:



0\. glossary.md

1\. constraints.md

2\. requirements.md

3\. architecture.md

4\. governance.md

5\. copilot-instructions.md

6\. standards.md

7\. tasks.md (optional)



---



\# Yes — There Is a Standard Anchor Prompt



Here is the canonical anchor for glossary.md.



You can paste this into your new chat as Step 0.



---



\### Glossary Anchor Prompt



```

We are beginning Day 0 of an AI-driven development lifecycle.



Your task is to generate glossary.md.



This document defines authoritative terminology for the repository.



The glossary must:

\- Define core architectural terms

\- Define system-layer names

\- Define integration terminology

\- Define AI-related governance terminology

\- Be precise and unambiguous

\- Avoid implementation details

\- Avoid requirements

\- Avoid constraints

\- Avoid architecture design decisions



This document stabilizes language only.



Each term must include:

\- Term name

\- Concise definition

\- Scope note (where applicable)

\- Explicit exclusions (if ambiguity is possible)



Do not generate any other documents.

Output only valid Markdown.

```



---



\# What Should Be Included



In your Unity + DLL environment, expect entries like:



\* Core

\* Infrastructure

\* Application Layer

\* Contracts

\* Host

\* Unity Adapter

\* External Integration

\* Adapter

\* Facade

\* Repository

\* Use Case

\* Vertical Slice

\* Bounded Context

\* Governance

\* Authority Level

\* ADR

\* Sync

\* Offline Mode



---



\# What Glossary Must NOT Do



It must not:



\* Describe how layers interact.

\* Define dependency rules.

\* Contain architecture diagrams.

\* Contain constraints.

\* Contain standards.

\* Reference specific implementation decisions.



If it does, you stop and correct it.



---



\# Important Discipline Rule



Glossary defines words.



Constraints define limits.



Requirements define behavior.



Architecture defines structure.



Governance defines authority.



Standards define code style.



If those bleed together, fix it immediately.



---



\# One More Important Note



Choose either:



\* `glossary.md`

&nbsp; or

\* `terminology.md`



Not both.



They serve the same purpose.



Use `glossary.md` — it’s more conventional and AI-recognizable.



---



\# Final Answer



Yes — there is a standard prompt.



Yes — it belongs before the original 7.



And yes — generating it first will materially improve AI consistency in later documents.



---



If you'd like, I can now simulate what a properly structured `glossary.md` should look like for your specific Unity + DLL architecture so you know what “good” looks like before starting Day 0.



