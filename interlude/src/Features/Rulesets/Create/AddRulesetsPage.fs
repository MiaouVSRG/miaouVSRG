namespace Interlude.Features.Rulesets

open Prelude
open Percyqaz.Flux.UI
open Interlude.UI

type AddRulesetsPage() =
    inherit Page()

    override this.Content() =
        page_container()
            .With(
                PageButton(%"rulesets.create.sc", fun () -> SCRulesetPage().Show())
                    .Pos(0),
                PageButton(%"rulesets.create.osu", fun () -> OsuRulesetPage().Show())
                    .Pos(2),
                PageButton(%"rulesets.create.quaver", fun () -> QuaverRulesetPage().Show())
                    .Pos(4),
                PageButton(%"rulesets.create.wife", fun () -> WifeRulesetPage().Show())
                    .Pos(6)
            )

    override this.Title = %"rulesets.add"