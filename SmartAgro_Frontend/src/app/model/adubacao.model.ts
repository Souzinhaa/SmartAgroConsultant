export interface AdubacaoModel {
    data?:{
        interpretacaoSaturacaoPorBases?: string,
        interpretacaoFosforo?: string,
        interpretacaoPotassio?: string,
        doseCalcario?: number,
        observacoesCalagem?: string,
        totalNitrogenio?: number,
        totalFosforo?: number,
        totalPotassio?: number,
        semeaduraPlantioNitrogenio?: number,
        semeaduraPlantioFosforo?: number,
        semeaduraPlantioPotassio?: number,
        coberturaNitrogenio?: number,
        formulacoesSugeridas?: FormulacoesModel[],
        observacoesAdubacao?: string
    }

        
}

export interface FormulacoesModel {
    composicaoNPK?: string,
    dose?: number
}