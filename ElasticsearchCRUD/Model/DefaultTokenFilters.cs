﻿namespace ElasticsearchCRUD.Model
{
	public static class DefaultTokenFilters
	{
		public const string Standard = "standard";
		public const string Asciifolding = "asciifolding";
		public const string Length = "length";
		public const string Lowercase = "lowercase";
		public const string Uppercase = "uppercase";
		public const string NGram = "nGram";
		public const string EdgeNGram = "edgeNGram";
		public const string PorterStem = "porter_stem";
		public const string Shingle = "shingle";
		public const string Stop = "stop";
		public const string WordDelimiter = "word_delimiter";
		public const string Stemmer = "stemmer";
		public const string StemmerOverride = "stemmer_override";
		public const string KeywordMarker = "keyword_marker";
		public const string KeywordRepeat = "keyword_repeat";
		public const string Kstem = "kstem";
		public const string Snowball = "snowball";
		public const string Phonetic = "phonetic";
		public const string Synonym = "synonym";
		// Compound Word Token Filter
		public const string Reverse = "reverse";
		public const string Elision = "elision";
		public const string Truncate = "truncate";
		public const string Unique = "unique";
		public const string PatternCapture = "pattern_capture";
		public const string PatternReplace = "pattern_replace";
		public const string Trim = "trim";
		public const string Limit = "limit";
		public const string Hunspell = "hunspell";
		public const string CommonGrams = "common_grams";
		// Normalization Token Filter
		// CJK Width Token Filter
		// CJK Bigram Token Filter
		// Delimited Payload Token Filter
		// Keep Words Token Filter
		// Keep Types Token Filter
		public const string Classic = "classic";
		public const string Apostrophe = "apostrophe";
		
	}
}